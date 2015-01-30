﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
#if ASPNETCORE50
using System.Reflection;
#endif
using Microsoft.AspNet.Razor.Generator.Compiler;
using Microsoft.AspNet.Razor.TagHelpers;
using Xunit;

namespace Microsoft.AspNet.Razor.Test.Generator
{
    public class CSharpTagHelperRenderingTest : TagHelperTestBase
    {
        private static IEnumerable<TagHelperDescriptor> PAndInputTagHelperDescriptors
        {
            get
            {
                var pAgePropertyInfo = typeof(TestType).GetProperty("Age");
                var inputTypePropertyInfo = typeof(TestType).GetProperty("Type");
                var checkedPropertyInfo = typeof(TestType).GetProperty("Checked");
                return new[]
                {
                    new TagHelperDescriptor("p",
                                            "PTagHelper",
                                            "SomeAssembly",
                                            new [] {
                                                new TagHelperAttributeDescriptor("age", pAgePropertyInfo)
                                            }),
                    new TagHelperDescriptor("input",
                                            "InputTagHelper",
                                            "SomeAssembly",
                                            new TagHelperAttributeDescriptor[] {
                                                new TagHelperAttributeDescriptor("type", inputTypePropertyInfo)
                                            }),
                    new TagHelperDescriptor("input",
                                            "InputTagHelper2",
                                            "SomeAssembly",
                                            new TagHelperAttributeDescriptor[] {
                                                new TagHelperAttributeDescriptor("type", inputTypePropertyInfo),
                                                new TagHelperAttributeDescriptor("checked", checkedPropertyInfo)
                                            })
                };
            }
        }

        public static TheoryData TagHelperDescriptorFlowTestData
        {
            get
            {
                return new TheoryData<string, // Test name
                                      string, // Baseline name
                                      IEnumerable<TagHelperDescriptor>, // TagHelperDescriptors provided
                                      IEnumerable<TagHelperDescriptor>, // Expected TagHelperDescriptors
                                      bool> // Design time mode.
                {
                    {
                        "SingleTagHelper",
                        "SingleTagHelper",
                        PAndInputTagHelperDescriptors,
                        PAndInputTagHelperDescriptors,
                        false
                    },
                    {
                        "SingleTagHelper",
                        "SingleTagHelper.DesignTime",
                        PAndInputTagHelperDescriptors,
                        PAndInputTagHelperDescriptors,
                        true
                    },
                    {
                        "BasicTagHelpers",
                        "BasicTagHelpers",
                        PAndInputTagHelperDescriptors,
                        PAndInputTagHelperDescriptors,
                        false
                    },
                    {
                        "BasicTagHelpers",
                        "BasicTagHelpers.DesignTime",
                        PAndInputTagHelperDescriptors,
                        PAndInputTagHelperDescriptors,
                        true
                    },
                    {
                        "BasicTagHelpers.RemoveTagHelper",
                        "BasicTagHelpers.RemoveTagHelper",
                        PAndInputTagHelperDescriptors,
                        Enumerable.Empty<TagHelperDescriptor>(),
                        false
                    },
                    {
                        "ComplexTagHelpers",
                        "ComplexTagHelpers",
                        PAndInputTagHelperDescriptors,
                        PAndInputTagHelperDescriptors,
                        false
                    },
                    {
                        "ComplexTagHelpers",
                        "ComplexTagHelpers.DesignTime",
                        PAndInputTagHelperDescriptors,
                        PAndInputTagHelperDescriptors,
                        true
                    }
                };
            }
        }

        [Theory]
        [MemberData(nameof(TagHelperDescriptorFlowTestData))]
        public void TagHelpers_RenderingOutputFlowsFoundTagHelperDescriptors(
            string testName,
            string baselineName,
            IEnumerable<TagHelperDescriptor> tagHelperDescriptors,
            IEnumerable<TagHelperDescriptor> expectedTagHelperDescriptors,
            bool designTimeMode)
        {
            RunTagHelperTest(
                testName,
                baseLineName: baselineName,
                tagHelperDescriptors: tagHelperDescriptors,
                onResults: (results) =>
                {
                    Assert.Equal(expectedTagHelperDescriptors,
                                 results.TagHelperDescriptors,
                                 TagHelperDescriptorComparer.Default);
                },
                designTimeMode: designTimeMode);
        }

        public static TheoryData DesignTimeTagHelperTestData
        {
            get
            {
                // Test resource name, baseline resource name, expected TagHelperDescriptors, expected LineMappings
                return new TheoryData<string, string, IEnumerable<TagHelperDescriptor>, List<LineMapping>>
                {
                    {
                        "SingleTagHelper",
                        "SingleTagHelper.DesignTime",
                        PAndInputTagHelperDescriptors,
                        new List<LineMapping>
                        {
                            BuildLineMapping(documentAbsoluteIndex: 14,
                                             documentLineIndex: 0,
                                             generatedAbsoluteIndex: 475,
                                             generatedLineIndex: 15,
                                             characterOffsetIndex: 14,
                                             contentLength: 17),
                            BuildLineMapping(documentAbsoluteIndex: 63,
                                             documentLineIndex: 2,
                                             generatedAbsoluteIndex: 964,
                                             generatedLineIndex: 34,
                                             characterOffsetIndex: 28,
                                             contentLength: 4)
                        }
                    },
                    {
                        "BasicTagHelpers",
                        "BasicTagHelpers.DesignTime",
                        PAndInputTagHelperDescriptors,
                        new List<LineMapping>
                        {
                            BuildLineMapping(documentAbsoluteIndex: 14,
                                             documentLineIndex: 0,
                                             generatedAbsoluteIndex: 475,
                                             generatedLineIndex: 15,
                                             characterOffsetIndex: 14,
                                             contentLength: 17),
                            BuildLineMapping(documentAbsoluteIndex: 195,
                                             documentLineIndex: 6,
                                             generatedAbsoluteIndex: 1580,
                                             generatedLineIndex: 44,
                                             characterOffsetIndex: 40,
                                             contentLength: 4)
                        }
                    },
                    {
                        "ComplexTagHelpers",
                        "ComplexTagHelpers.DesignTime",
                        PAndInputTagHelperDescriptors,
                        new List<LineMapping>
                        {
                            BuildLineMapping(14, 0, 479, 15, 14, 17),
                            BuildLineMapping(36, 2, 1, 1001, 35, 0, 48),
                            BuildLineMapping(211, 9, 1119, 44, 0, 12),
                            BuildLineMapping(224, 9, 13, 1215, 50, 12, 27),
                            BuildLineMapping(352, 12, 1613, 62, 0, 48),
                            BuildLineMapping(446, 15, 46, 1804, 71, 6, 8),
                            BuildLineMapping(463, 15, 2127, 79, 63, 4),
                            BuildLineMapping(507, 16, 31, 2334, 86, 6, 30),
                            BuildLineMapping(574, 17, 30, 2683, 95, 0, 10),
                            BuildLineMapping(607, 17, 63, 2765, 101, 0, 8),
                            BuildLineMapping(638, 17, 94, 2845, 107, 0, 1),
                            BuildLineMapping(645, 18, 3099, 116, 0, 15),
                            BuildLineMapping(163, 7, 32, 3248, 123, 6, 12),
                            BuildLineMapping(725, 21, 3331, 128, 0, 12),
                            BuildLineMapping(739, 21, 3429, 134, 14, 21),
                            BuildLineMapping(793, 22, 30, 3686, 142, 28, 7),
                            BuildLineMapping(691, 20, 17, 3842, 148, 19, 23),
                            BuildLineMapping(714, 20, 40, 3865, 148, 42, 7),
                            BuildLineMapping(903, 25, 30, 4107, 155, 28, 30),
                            BuildLineMapping(837, 24, 16, 4286, 161, 19, 8),
                            BuildLineMapping(846, 24, 25, 4294, 161, 27, 23),
                            BuildLineMapping(1032, 28, 4552, 168, 28, 30),
                            BuildLineMapping(970, 27, 16, 4731, 174, 19, 30),
                            BuildLineMapping(1162, 31, 4996, 181, 28, 3),
                            BuildLineMapping(1167, 31, 33, 4999, 181, 31, 27),
                            BuildLineMapping(1195, 31, 61, 5026, 181, 58, 10),
                            BuildLineMapping(1100, 30, 18, 5185, 187, 19, 29),
                            BuildLineMapping(1237, 34, 5285, 192, 0, 1),
                        }
                    }
                };
            }
        }

        [Theory]
        [MemberData(nameof(DesignTimeTagHelperTestData))]
        public void TagHelpers_GenerateExpectedDesignTimeOutput(string testName,
                                                                string baseLineName,
                                                                IEnumerable<TagHelperDescriptor> tagHelperDescriptors,
                                                                List<LineMapping> expectedDesignTimePragmas)
        {
            // Act & Assert
            RunTagHelperTest(testName,
                             baseLineName,
                             designTimeMode: true,
                             tagHelperDescriptors: tagHelperDescriptors,
                             expectedDesignTimePragmas: expectedDesignTimePragmas);
        }

        public static TheoryData RuntimeTimeTagHelperTestData
        {
            get
            {
                // Test resource name, expected TagHelperDescriptors
                // Note: The baseline resource name is equivalent to the test resource name.
                return new TheoryData<string, IEnumerable<TagHelperDescriptor>>
                {
                    { "SingleTagHelper", PAndInputTagHelperDescriptors },
                    { "BasicTagHelpers", PAndInputTagHelperDescriptors },
                    { "BasicTagHelpers.RemoveTagHelper", PAndInputTagHelperDescriptors },
                    { "ComplexTagHelpers", PAndInputTagHelperDescriptors },
                };
            }
        }

        [Theory]
        [MemberData(nameof(RuntimeTimeTagHelperTestData))]
        public void TagHelpers_GenerateExpectedRuntimeOutput(string testName,
                                                             IEnumerable<TagHelperDescriptor> tagHelperDescriptors)
        {
            // Act & Assert
            RunTagHelperTest(testName, tagHelperDescriptors: tagHelperDescriptors);
        }

        [Fact]
        public void CSharpCodeGenerator_CorrectlyGeneratesMappings_ForRemoveTagHelperDirective()
        {
            // Act & Assert
            RunTagHelperTest("RemoveTagHelperDirective",
                             designTimeMode: true,
                             expectedDesignTimePragmas: new List<LineMapping>()
                             {
                                    BuildLineMapping(documentAbsoluteIndex: 17,
                                                     documentLineIndex: 0,
                                                     generatedAbsoluteIndex: 442,
                                                     generatedLineIndex: 14,
                                                     characterOffsetIndex: 17,
                                                     contentLength: 17)
                             });
        }

        [Fact]
        public void CSharpCodeGenerator_CorrectlyGeneratesMappings_ForAddTagHelperDirective()
        {
            // Act & Assert
            RunTagHelperTest("AddTagHelperDirective",
                             designTimeMode: true,
                             expectedDesignTimePragmas: new List<LineMapping>()
                             {
                                    BuildLineMapping(documentAbsoluteIndex: 14,
                                                     documentLineIndex: 0,
                                                     generatedAbsoluteIndex: 433,
                                                     generatedLineIndex: 14,
                                                     characterOffsetIndex: 14,
                                                     contentLength: 17)
                             });
        }

        [Fact]
        public void TagHelpers_Directive_GenerateDesignTimeMappings()
        {
            // Act & Assert
            RunTagHelperTest("AddTagHelperDirective",
                             designTimeMode: true,
                             tagHelperDescriptors: new[] {
                                new TagHelperDescriptor("p", "pTagHelper", "SomeAssembly")
                             });
        }

        [Theory]
        [InlineData("TagHelpersInSection")]
        [InlineData("TagHelpersInHelper")]
        public void TagHelpers_WithinHelpersAndSections_GeneratesExpectedOutput(string testType)
        {
            // Arrange
            var propertyInfo = typeof(TestType).GetProperty("BoundProperty");
            var tagHelperDescriptors = new TagHelperDescriptor[]
            {
                new TagHelperDescriptor("MyTagHelper",
                                        "MyTagHelper",
                                        "SomeAssembly",
                                        new [] {
                                            new TagHelperAttributeDescriptor("BoundProperty",
                                                                             propertyInfo)
                                        }),
                new TagHelperDescriptor("NestedTagHelper", "NestedTagHelper", "SomeAssembly")
            };

            // Act & Assert
            RunTagHelperTest(testType, tagHelperDescriptors: tagHelperDescriptors);
        }

        private class TestType
        {
            public int Age { get; set; }

            public string Type { get; set; }

            public bool Checked { get; set; }

            public string BoundProperty { get; set; }
        }
    }
}
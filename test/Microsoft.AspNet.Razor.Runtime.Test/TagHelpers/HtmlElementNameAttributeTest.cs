﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit;

namespace Microsoft.AspNet.Razor.Runtime.TagHelpers
{
    public class HtmlElementNameAttributeTest
    {
        public static TheoryData InvalidTagNameData
        {
            get
            {
                var invalidTagNameError =
                    "Tag helpers cannot target element name '{0}' because it contains a '{1}' character.";
                var nullOrWhitespaceTagNameError =
                    "Tag name cannot be null or whitespace.";

                // tagName, expectedExceptionMessage
                return new TheoryData<string, string>
                {
                    { "!", string.Format(invalidTagNameError, "!", "!") },
                    { "hello!", string.Format(invalidTagNameError, "hello!", "!") },
                    { "!hello", string.Format(invalidTagNameError, "!hello", "!") },
                    { "he!lo", string.Format(invalidTagNameError, "he!lo", "!") },
                    { "!he!lo!", string.Format(invalidTagNameError, "!he!lo!", "!") },
                    { string.Empty, nullOrWhitespaceTagNameError },
                    { Environment.NewLine, nullOrWhitespaceTagNameError },
                    { "\t", nullOrWhitespaceTagNameError },
                    { " \t ", nullOrWhitespaceTagNameError },
                    { " ", nullOrWhitespaceTagNameError },
                    { Environment.NewLine + " ", nullOrWhitespaceTagNameError },
                    { null, nullOrWhitespaceTagNameError },
                };
            }
        }

        [Theory]
        [MemberData(nameof(InvalidTagNameData))]
        public void SingleArgument_ThrowsOnInvalidTagNames(string tagName, string expectedExceptionMessage)
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new HtmlElementNameAttribute(tagName));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }

        [Theory]
        [MemberData(nameof(InvalidTagNameData))]
        public void MultipleArgument_ThrowsOnInvalidTagNames(string tagName, string expectedExceptionMessage)
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new HtmlElementNameAttribute("p", tagName));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }
    }
}
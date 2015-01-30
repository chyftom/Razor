// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNet.Razor.Parser;
using Microsoft.AspNet.Razor.TagHelpers;
using Microsoft.AspNet.Razor.Text;

namespace Microsoft.AspNet.Razor.Runtime.TagHelpers
{
    /// <summary>
    /// Used to resolve <see cref="TagHelperDescriptor"/>s.
    /// </summary>
    public class TagHelperDescriptorResolver : ITagHelperDescriptorResolver
    {
        private readonly TagHelperTypeResolver _typeResolver;

        // internal for testing
        internal TagHelperDescriptorResolver(TagHelperTypeResolver typeResolver)
        {
            _typeResolver = typeResolver;
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="TagHelperDescriptorResolver"/> class.
        /// </summary>
        public TagHelperDescriptorResolver()
            : this(new TagHelperTypeResolver())
        {
        }

        /// <inheritdoc />
        public IEnumerable<TagHelperDescriptor> Resolve([NotNull] TagHelperDescriptorResolutionContext context)
        {
            var resolvedDescriptors = new HashSet<TagHelperDescriptor>(TagHelperDescriptorComparer.Default);

            foreach (var directiveDescriptor in context.DirectiveDescriptors)
            {
                try
                {
                    var lookupInfo = GetLookupInfo(directiveDescriptor, context.ErrorSink);

                    // Could not resolve the lookup info.
                    if (lookupInfo == null)
                    {
                        return Enumerable.Empty<TagHelperDescriptor>();
                    }

                    if (directiveDescriptor.DirectiveType == TagHelperDirectiveType.RemoveTagHelper)
                    {
                        resolvedDescriptors.RemoveWhere(descriptor => MatchesLookupInfo(descriptor, lookupInfo));
                    }
                    else if (directiveDescriptor.DirectiveType == TagHelperDirectiveType.AddTagHelper)
                    {
                        var descriptors = ResolveDescriptorsInAssembly(lookupInfo.AssemblyName,
                                                                       directiveDescriptor.Location,
                                                                       context.ErrorSink);

                        // Only use descriptors that match our lookup info
                        descriptors = descriptors.Where(descriptor => MatchesLookupInfo(descriptor, lookupInfo));

                        resolvedDescriptors.UnionWith(descriptors);
                    }
                }
                catch (Exception ex)
                {
                    var directiveName = "@" + directiveDescriptor.DirectiveType.ToString().ToLowerInvariant();

                    context.ErrorSink.OnError(
                        directiveDescriptor.Location,
                        Resources.FormatTagHelperDescriptorResolver_EncounteredUnexpectedError(
                            directiveName,
                            directiveDescriptor.LookupText,
                            ex.Message));
                }
            }

            return resolvedDescriptors;
        }

        /// <summary>
        /// Resolves all <see cref="TagHelperDescriptor"/>s for <see cref="ITagHelper"/>s from the given
        /// <paramref name="assemblyName"/>.
        /// </summary>
        /// <param name="assemblyName">
        /// The name of the assembly to resolve <see cref="TagHelperDescriptor"/>s from.
        /// </param>
        /// <param name="documentLocation">The <see cref="SourceLocation"/> of the directive.</param>
        /// <param name="errorSink">Used to record errors found when resolving <see cref="TagHelperDescriptor"/>s 
        /// within the given <paramref name="assemblyName"/>.</param>
        /// <returns><see cref="TagHelperDescriptor"/>s for <see cref="ITagHelper"/>s from the given
        /// <paramref name="assemblyName"/>.</returns>
        // This is meant to be overridden by tooling to enable assembly level caching.
        protected virtual IEnumerable<TagHelperDescriptor> ResolveDescriptorsInAssembly(string assemblyName,
                                                                                        SourceLocation documentLocation,
                                                                                        ParserErrorSink errorSink)
        {
            // Resolve valid tag helper types from the assembly.
            var tagHelperTypes = _typeResolver.Resolve(assemblyName, documentLocation, errorSink);

            // Convert types to TagHelperDescriptors
            var descriptors = tagHelperTypes.SelectMany(TagHelperDescriptorFactory.CreateDescriptors);

            return descriptors;
        }

        private static bool MatchesLookupInfo(TagHelperDescriptor descriptor, LookupInfo lookupInfo)
        {
            if (!string.Equals(descriptor.AssemblyName, lookupInfo.AssemblyName, StringComparison.Ordinal))
            {
                return false;
            }

            // We need to escape the typeMatcher so we can choose to only allow specific regex.
            var escapedTypeMatcher = Regex.Escape(lookupInfo.TypeMatcher);

            // We surround the escapedTypeMatcher with ^ and $ in order ot ensure a regex match matches the entire 
            // string. We also replace any '*' characters with regex to match any content.
            var strRegexMatcher = "^" + escapedTypeMatcher.Replace(@"\*", ".*?") + "$";

            // We allow '*' in the output so we need to replace its escaped counterpart with valid regex.
            var regexMatcher = new Regex(strRegexMatcher, RegexOptions.Singleline);

            return regexMatcher.IsMatch(descriptor.TypeName);
        }

        private static LookupInfo GetLookupInfo(TagHelperDirectiveDescriptor directiveDescriptor,
                                                ParserErrorSink errorSink)
        {
            var lookupText = directiveDescriptor.LookupText;
            var lookupStrings = lookupText?.Split(new[] { ',' });

            // Ensure that we have valid lookupStrings to work with. Valid formats are:
            // "assemblyName"
            // "typeName, assemblyName"
            if (lookupStrings == null ||
                lookupStrings.Any(string.IsNullOrWhiteSpace) ||
                lookupStrings.Length != 2)
            {
                errorSink.OnError(
                    directiveDescriptor.Location,
                    Resources.FormatTagHelperDescriptorResolver_InvalidTagHelperLookupText(lookupText));

                return null;
            }

            return new LookupInfo
            {
                TypeMatcher = lookupStrings[0].Trim(),
                AssemblyName = lookupStrings[1].Trim()
            };
        }

        private class LookupInfo
        {
            public string AssemblyName { get; set; }

            public string TypeMatcher { get; set; }
        }
    }
}
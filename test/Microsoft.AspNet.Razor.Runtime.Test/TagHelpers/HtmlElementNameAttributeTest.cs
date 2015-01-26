// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit;

namespace Microsoft.AspNet.Razor.Runtime.TagHelpers
{
    public class HtmlElementNameAttributeTest
    {
        [Fact]
        public void SingleArgument_CannotTargetBang()
        {
            var expectedExceptionMessage = "Tag helpers cannot target element name \"!\".";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new HtmlElementNameAttribute("!"));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }

        [Fact]
        public void MultipleArgument_CannotTargetBang()
        {
            var expectedExceptionMessage = "Tag helpers cannot target element name \"!\".";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new HtmlElementNameAttribute("p", "!"));
            Assert.Equal(exception.Message, expectedExceptionMessage);
        }
    }
}
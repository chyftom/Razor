#pragma checksum "ComplexTagHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7158abc69d261099393d49d82670ec64a94d9770"
namespace TestOutput
{
    using Microsoft.AspNet.Razor.Runtime.TagHelpers;
    using System;
    using System.Threading.Tasks;

    public class ComplexTagHelpers
    {
        #line hidden
        #pragma warning disable 0414
        private System.IO.TextWriter __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private TagHelperExecutionContext __tagHelperExecutionContext = null;
        private TagHelperRunner __tagHelperRunner = new TagHelperRunner();
        private TagHelperScopeManager __tagHelperScopeManager = new TagHelperScopeManager();
        private PTagHelper __PTagHelper = null;
        private InputTagHelper __InputTagHelper = null;
        private InputTagHelper2 __InputTagHelper2 = null;
        #line hidden
        public ComplexTagHelpers()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            Instrumentation.BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            Instrumentation.EndContext();
#line 3 "ComplexTagHelpers.cshtml"
 if (true)
{
    var checkbox = "checkbox";


#line default
#line hidden

            Instrumentation.BeginContext(78, 55, true);
            WriteLiteral("    <div class=\"randomNonTagHelperAttribute\">\r\n        ");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", "test", async() => {
                WriteLiteral("\r\n            <h1>Set Time:</h1>\r\n");
#line 10 "ComplexTagHelpers.cshtml"
            

#line default
#line hidden

#line 10 "ComplexTagHelpers.cshtml"
             if (false)
            {

#line default
#line hidden

                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", "test", async() => {
                    WriteLiteral("New Time: ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                    }
                    , StartWritingScope, EndWritingScope);
                    __InputTagHelper = CreateTagHelper<InputTagHelper>();
                    __tagHelperExecutionContext.Add(__InputTagHelper);
                    __InputTagHelper.Type = "text";
                    __tagHelperExecutionContext.AddTagHelperAttribute("type", __InputTagHelper.Type);
                    __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                    __tagHelperExecutionContext.Add(__InputTagHelper2);
                    __InputTagHelper2.Type = __InputTagHelper.Type;
                    __tagHelperExecutionContext.AddHtmlAttribute("value", "");
                    __tagHelperExecutionContext.AddHtmlAttribute("placeholder", "Enter in a new time...");
                    __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                    WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                    if (__tagHelperExecutionContext.Output.ContentSet)
                    {
                        WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                    }
                    else if (__tagHelperExecutionContext.ChildContentRetrieved)
                    {
                        WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                    }
                    else
                    {
                        __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                    }
                    WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                , StartWritingScope, EndWritingScope);
                __PTagHelper = CreateTagHelper<PTagHelper>();
                __tagHelperExecutionContext.Add(__PTagHelper);
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#line 13 "ComplexTagHelpers.cshtml"
            }
            else
            {

#line default
#line hidden

                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", "test", async() => {
                    WriteLiteral("Current Time: ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                    }
                    , StartWritingScope, EndWritingScope);
                    __InputTagHelper = CreateTagHelper<InputTagHelper>();
                    __tagHelperExecutionContext.Add(__InputTagHelper);
                    StartWritingScope();
#line 16 "ComplexTagHelpers.cshtml"
Write(checkbox);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWritingScope();
                    __InputTagHelper.Type = __tagHelperStringValueBuffer.ToString();
                    __tagHelperExecutionContext.AddTagHelperAttribute("type", __InputTagHelper.Type);
                    __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                    __tagHelperExecutionContext.Add(__InputTagHelper2);
                    __InputTagHelper2.Type = __InputTagHelper.Type;
#line 16 "ComplexTagHelpers.cshtml"
                                   __InputTagHelper2.Checked = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("checked", __InputTagHelper2.Checked);
                    __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                    WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                    if (__tagHelperExecutionContext.Output.ContentSet)
                    {
                        WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                    }
                    else if (__tagHelperExecutionContext.ChildContentRetrieved)
                    {
                        WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                    }
                    else
                    {
                        __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                    }
                    WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                , StartWritingScope, EndWritingScope);
                __PTagHelper = CreateTagHelper<PTagHelper>();
                __tagHelperExecutionContext.Add(__PTagHelper);
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                }
                , StartWritingScope, EndWritingScope);
                __InputTagHelper = CreateTagHelper<InputTagHelper>();
                __tagHelperExecutionContext.Add(__InputTagHelper);
                StartWritingScope();
#line 17 "ComplexTagHelpers.cshtml"
Write(true ? "checkbox" : "anything");

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWritingScope();
                __InputTagHelper.Type = __tagHelperStringValueBuffer.ToString();
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __InputTagHelper.Type);
                __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                __tagHelperExecutionContext.Add(__InputTagHelper2);
                __InputTagHelper2.Type = __InputTagHelper.Type;
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                }
                , StartWritingScope, EndWritingScope);
                __InputTagHelper = CreateTagHelper<InputTagHelper>();
                __tagHelperExecutionContext.Add(__InputTagHelper);
                StartWritingScope();
#line 18 "ComplexTagHelpers.cshtml"
if(true) {

#line default
#line hidden

                WriteLiteral(" checkbox ");
#line 18 "ComplexTagHelpers.cshtml"
} else {

#line default
#line hidden

                WriteLiteral(" anything ");
#line 18 "ComplexTagHelpers.cshtml"
}

#line default
#line hidden

                __tagHelperStringValueBuffer = EndWritingScope();
                __InputTagHelper.Type = __tagHelperStringValueBuffer.ToString();
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __InputTagHelper.Type);
                __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                __tagHelperExecutionContext.Add(__InputTagHelper2);
                __InputTagHelper2.Type = __InputTagHelper.Type;
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#line 19 "ComplexTagHelpers.cshtml"
            }

#line default
#line hidden

                WriteLiteral("        ");
            }
            , StartWritingScope, EndWritingScope);
            __PTagHelper = CreateTagHelper<PTagHelper>();
            __tagHelperExecutionContext.Add(__PTagHelper);
            StartWritingScope();
            WriteLiteral("Current Time: ");
#line 8 "ComplexTagHelpers.cshtml"
Write(DateTime.Now);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWritingScope();
            __tagHelperExecutionContext.AddHtmlAttribute("time", __tagHelperStringValueBuffer.ToString());
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
            }
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(666, 10, true);
            WriteLiteral("\r\n        ");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", "test", async() => {
                WriteLiteral("\r\n");
#line 22 "ComplexTagHelpers.cshtml"
            

#line default
#line hidden

#line 22 "ComplexTagHelpers.cshtml"
               var @object = false;

#line default
#line hidden

                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                }
                , StartWritingScope, EndWritingScope);
                __InputTagHelper = CreateTagHelper<InputTagHelper>();
                __tagHelperExecutionContext.Add(__InputTagHelper);
                __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                __tagHelperExecutionContext.Add(__InputTagHelper2);
#line 23 "ComplexTagHelpers.cshtml"
__InputTagHelper2.Checked = @object;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __InputTagHelper2.Checked);
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            , StartWritingScope, EndWritingScope);
            __PTagHelper = CreateTagHelper<PTagHelper>();
            __tagHelperExecutionContext.Add(__PTagHelper);
#line 21 "ComplexTagHelpers.cshtml"
__PTagHelper.Age = DateTimeOffset.Now.Year - 1970;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __PTagHelper.Age);
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
            }
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(813, 10, true);
            WriteLiteral("\r\n        ");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", "test", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                }
                , StartWritingScope, EndWritingScope);
                __InputTagHelper = CreateTagHelper<InputTagHelper>();
                __tagHelperExecutionContext.Add(__InputTagHelper);
                __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                __tagHelperExecutionContext.Add(__InputTagHelper2);
#line 26 "ComplexTagHelpers.cshtml"
__InputTagHelper2.Checked = DateTimeOffset.Now.Year > 2014;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __InputTagHelper2.Checked);
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            , StartWritingScope, EndWritingScope);
            __PTagHelper = CreateTagHelper<PTagHelper>();
            __tagHelperExecutionContext.Add(__PTagHelper);
#line 25 "ComplexTagHelpers.cshtml"
__PTagHelper.Age = -1970 + DateTimeOffset.Now.Year;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __PTagHelper.Age);
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
            }
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(946, 10, true);
            WriteLiteral("\r\n        ");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", "test", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                }
                , StartWritingScope, EndWritingScope);
                __InputTagHelper = CreateTagHelper<InputTagHelper>();
                __tagHelperExecutionContext.Add(__InputTagHelper);
                __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                __tagHelperExecutionContext.Add(__InputTagHelper2);
#line 29 "ComplexTagHelpers.cshtml"
__InputTagHelper2.Checked = DateTimeOffset.Now.Year > 2014;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __InputTagHelper2.Checked);
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            , StartWritingScope, EndWritingScope);
            __PTagHelper = CreateTagHelper<PTagHelper>();
            __tagHelperExecutionContext.Add(__PTagHelper);
#line 28 "ComplexTagHelpers.cshtml"
__PTagHelper.Age = DateTimeOffset.Now.Year - 1970;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __PTagHelper.Age);
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
            }
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(1074, 10, true);
            WriteLiteral("\r\n        ");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", "test", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", "test", async() => {
                }
                , StartWritingScope, EndWritingScope);
                __InputTagHelper = CreateTagHelper<InputTagHelper>();
                __tagHelperExecutionContext.Add(__InputTagHelper);
                __InputTagHelper2 = CreateTagHelper<InputTagHelper2>();
                __tagHelperExecutionContext.Add(__InputTagHelper2);
#line 32 "ComplexTagHelpers.cshtml"
__InputTagHelper2.Checked =      DateTimeOffset.Now.Year   > 2014   ;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __InputTagHelper2.Checked);
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
                }
                WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            , StartWritingScope, EndWritingScope);
            __PTagHelper = CreateTagHelper<PTagHelper>();
            __tagHelperExecutionContext.Add(__PTagHelper);
#line 31 "ComplexTagHelpers.cshtml"
__PTagHelper.Age = "My age is this long.".Length;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __PTagHelper.Age);
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                WriteLiteral(__tagHelperExecutionContext.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
            }
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(1217, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            Instrumentation.EndContext();
#line 35 "ComplexTagHelpers.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}

#pragma checksum "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6abdd183f0957f5a57a546288c91f66c78ebd7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bible_SearchForVerse), @"mvc.1.0.view", @"/Views/Bible/SearchForVerse.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\_ViewImports.cshtml"
using BibleVerseApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\_ViewImports.cshtml"
using BibleVerseApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6abdd183f0957f5a57a546288c91f66c78ebd7b", @"/Views/Bible/SearchForVerse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7be7224105b7afe6ed8bfaf765222c29ae543", @"/Views/_ViewImports.cshtml")]
    public class Views_Bible_SearchForVerse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BibleVerseApplication.Models.BibleVerse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
           Write(Html.DisplayNameFor(model => model.Book));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
           Write(Html.DisplayNameFor(model => model.Chapter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
           Write(Html.DisplayNameFor(model => model.Verse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
           Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
           Write(Html.DisplayNameFor(model => model.Testament));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
               Write(Html.DisplayFor(modelItem => item.Chapter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
               Write(Html.DisplayFor(modelItem => item.Verse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
               Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
               Write(Html.DisplayFor(modelItem => item.Testament));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\btzla\Documents\Programming\Projects\Projects\C#\ASP.NET\BibleVerseApplication\Views\Bible\SearchForVerse.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6abdd183f0957f5a57a546288c91f66c78ebd7b8696", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BibleVerseApplication.Models.BibleVerse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
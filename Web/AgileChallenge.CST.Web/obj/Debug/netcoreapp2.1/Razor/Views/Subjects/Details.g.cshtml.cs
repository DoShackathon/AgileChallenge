#pragma checksum "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7dc79752fe00d71c6d777b429c4108970c94f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subjects_Details), @"mvc.1.0.view", @"/Views/Subjects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subjects/Details.cshtml", typeof(AspNetCore.Views_Subjects_Details))]
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
#line 1 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\_ViewImports.cshtml"
using AgileChallenge.CST.Web;

#line default
#line hidden
#line 2 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\_ViewImports.cshtml"
using AgileChallenge.CST.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dc79752fe00d71c6d777b429c4108970c94f26", @"/Views/Subjects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"013771f7ac8595899803adb8bb2b905becb97e8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Subjects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgileChallenge.CST.Web.data.Subject>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Subject</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 45, false);
#line 14 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(256, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(300, 41, false);
#line 17 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(341, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(385, 44, false);
#line 20 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(429, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(473, 40, false);
#line 23 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(557, 46, false);
#line 26 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(603, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(647, 42, false);
#line 29 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(689, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(733, 48, false);
#line 32 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(781, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(825, 44, false);
#line 35 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(869, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(913, 47, false);
#line 38 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MobilePhone));

#line default
#line hidden
            EndContext();
            BeginContext(960, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1004, 43, false);
#line 41 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.MobilePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1091, 45, false);
#line 44 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1180, 41, false);
#line 47 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.WorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1265, 45, false);
#line 50 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1354, 41, false);
#line 53 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1439, 48, false);
#line 56 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLine1));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1531, 44, false);
#line 59 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressLine1));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1619, 48, false);
#line 62 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLine2));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1711, 44, false);
#line 65 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressLine2));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1799, 40, false);
#line 68 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1883, 36, false);
#line 71 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1963, 45, false);
#line 74 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StateCode));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2052, 41, false);
#line 77 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.StateCode));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2137, 47, false);
#line 80 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CountryCode));

#line default
#line hidden
            EndContext();
            BeginContext(2184, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2228, 43, false);
#line 83 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.CountryCode));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2315, 43, false);
#line 86 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2358, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2402, 39, false);
#line 89 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2441, 49, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2490, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2beba543b9f447a0add8bacf273868b3", async() => {
                BeginContext(2543, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Details.cshtml"
                           WriteLiteral(Model.ContactId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2551, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2559, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e2767ca0f5c47f9a2367022e9c8d0e0", async() => {
                BeginContext(2581, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2597, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgileChallenge.CST.Web.data.Subject> Html { get; private set; }
    }
}
#pragma warning restore 1591
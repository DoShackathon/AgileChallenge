#pragma checksum "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e95a6f478223408ff2a946fe0b507ee4e243951d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subjects_Index), @"mvc.1.0.view", @"/Views/Subjects/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subjects/Index.cshtml", typeof(AspNetCore.Views_Subjects_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95a6f478223408ff2a946fe0b507ee4e243951d", @"/Views/Subjects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"013771f7ac8595899803adb8bb2b905becb97e8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Subjects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AgileChallenge.CST.Web.data.Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5c69fb15514e46a17fe5530ba7d137", async() => {
                BeginContext(152, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 45, false);
#line 16 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 44, false);
#line 19 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 46, false);
#line 22 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(562, 48, false);
#line 25 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(610, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(666, 47, false);
#line 28 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MobilePhone));

#line default
#line hidden
            EndContext();
            BeginContext(713, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(769, 45, false);
#line 31 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(814, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(870, 45, false);
#line 34 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(915, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(971, 48, false);
#line 37 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AddressLine1));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1075, 48, false);
#line 40 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AddressLine2));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1179, 40, false);
#line 43 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1275, 45, false);
#line 46 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StateCode));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1376, 47, false);
#line 49 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CountryCode));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1479, 43, false);
#line 52 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 58 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1640, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1689, 44, false);
#line 61 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1789, 43, false);
#line 64 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1888, 45, false);
#line 67 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1989, 47, false);
#line 70 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2092, 46, false);
#line 73 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MobilePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2194, 44, false);
#line 76 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2294, 44, false);
#line 79 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2394, 47, false);
#line 82 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AddressLine1));

#line default
#line hidden
            EndContext();
            BeginContext(2441, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2497, 47, false);
#line 85 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AddressLine2));

#line default
#line hidden
            EndContext();
            BeginContext(2544, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2600, 39, false);
#line 88 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(2639, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2695, 44, false);
#line 91 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StateCode));

#line default
#line hidden
            EndContext();
            BeginContext(2739, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2795, 46, false);
#line 94 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CountryCode));

#line default
#line hidden
            EndContext();
            BeginContext(2841, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2897, 42, false);
#line 97 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2939, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2994, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6b9fb195da48c682c2e255e8b933a7", async() => {
                BeginContext(3046, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
                                       WriteLiteral(item.ContactId);

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
            BeginContext(3054, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3074, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "137fd6bf306841ceb27ed66f85b11776", async() => {
                BeginContext(3129, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
                                          WriteLiteral(item.ContactId);

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
            BeginContext(3140, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3160, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fecac2f486bd4e0f87615bbc86ffe2f9", async() => {
                BeginContext(3214, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
                                         WriteLiteral(item.ContactId);

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
            BeginContext(3224, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 105 "C:\_AgileChallenge\Web\AgileChallenge.CST.Web\Views\Subjects\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3263, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AgileChallenge.CST.Web.data.Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591

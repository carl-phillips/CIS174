#pragma checksum "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f13435345bce38d5f55d116b62eaaf7e3d3dbc44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FamousPeople_View), @"mvc.1.0.view", @"/Views/FamousPeople/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FamousPeople/View.cshtml", typeof(AspNetCore.Views_FamousPeople_View))]
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
#line 1 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 3 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
#line 4 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13435345bce38d5f55d116b62eaaf7e3d3dbc44", @"/Views/FamousPeople/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a053c264e8544f2fed4e0e62d0d225d5d02dd7ac", @"/Views/_ViewImports.cshtml")]
    public class Views_FamousPeople_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
  
    ViewData["Title"] = Model.FirstName + Model.LastName;

#line default
#line hidden
            BeginContext(85, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(90, 15, false);
#line 5 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(105, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(107, 14, false);
#line 5 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(121, 17, true);
            WriteLiteral("</h2>\r\n<h4>City: ");
            EndContext();
            BeginContext(139, 10, false);
#line 6 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
     Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(149, 18, true);
            WriteLiteral("</h4>\r\n<h4>State: ");
            EndContext();
            BeginContext(168, 11, false);
#line 7 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
      Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(179, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(186, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c08bab870ea442e7ae67532664c520b7", async() => {
                BeginContext(237, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(256, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58232562d0f4491184c3fd1ecd0eca50", async() => {
                    BeginContext(326, 4, true);
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
#line 10 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(334, 68, true);
                WriteLiteral("\r\n        <button class=\"btn btn-danger\">Delete</button>\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(409, 8, true);
            WriteLiteral("\r\n<dl>\r\n");
            EndContext();
#line 15 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
     foreach (var item in Model.Accomplishments)
    {

#line default
#line hidden
            BeginContext(474, 8, true);
            WriteLiteral("    <dt>");
            EndContext();
            BeginContext(483, 9, false);
#line 17 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(492, 15, true);
            WriteLiteral("</dt>\r\n    <dd>");
            EndContext();
            BeginContext(508, 25, false);
#line 18 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
   Write(item.DateOfAccomplishment);

#line default
#line hidden
            EndContext();
            BeginContext(533, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 19 "C:\Users\Carl\Documents\GitHub\CIS174\CIS174_TestCoreApp\Views\FamousPeople\View.cshtml"
    }

#line default
#line hidden
            BeginContext(547, 5, true);
            WriteLiteral("</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591

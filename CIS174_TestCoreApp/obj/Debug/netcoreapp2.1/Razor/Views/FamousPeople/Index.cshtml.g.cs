#pragma checksum "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\FamousPeople\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe277b34235679dc6e7694462144f140e9dbce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FamousPeople_Index), @"mvc.1.0.view", @"/Views/FamousPeople/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FamousPeople/Index.cshtml", typeof(AspNetCore.Views_FamousPeople_Index))]
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
#line 1 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 3 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
#line 4 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe277b34235679dc6e7694462144f140e9dbce6", @"/Views/FamousPeople/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a053c264e8544f2fed4e0e62d0d225d5d02dd7ac", @"/Views/_ViewImports.cshtml")]
    public class Views_FamousPeople_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<CIS174_TestCoreApp.Models.FamousPerson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\FamousPeople\Index.cshtml"
  
    ViewData["Title"] = "Menus";

#line default
#line hidden
            BeginContext(101, 311, true);
            WriteLiteral(@"<div class=""table-responsive"">
    <table class=""table table-striped recipe"">
        <thead>
            <tr>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Accomplishments</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 16 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\FamousPeople\Index.cshtml"
             foreach (var person in Model)
            {

#line default
#line hidden
            BeginContext(471, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(518, 16, false);
#line 19 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\FamousPeople\Index.cshtml"
                   Write(person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(534, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(566, 15, false);
#line 20 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\FamousPeople\Index.cshtml"
                   Write(person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(581, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\FamousPeople\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(626, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
            BeginContext(666, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddfbdc79bcc94809ad77e60450454856", async() => {
                BeginContext(713, 17, true);
                WriteLiteral("Create new Person");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<CIS174_TestCoreApp.Models.FamousPerson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
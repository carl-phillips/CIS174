#pragma checksum "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aed6509f5c31ec9d8322f91af74061d7fb405955"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Index.cshtml", typeof(AspNetCore.Views_Person_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed6509f5c31ec9d8322f91af74061d7fb405955", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a053c264e8544f2fed4e0e62d0d225d5d02dd7ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIS174_TestCoreApp.Models.CreatePersonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 26, true);
            WriteLiteral("\r\n<h2>Create Person</h2>\r\n");
            EndContext();
            BeginContext(82, 3735, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8645f59e3de14b2a912d03f1f1357c7b", async() => {
                BeginContext(102, 148, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(251, 31, false);
#line 9 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(282, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(369, 32, false);
#line 12 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(401, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(511, 43, false);
#line 15 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(554, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(694, 32, false);
#line 21 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.MiddleName));

#line default
#line hidden
                EndContext();
                BeginContext(726, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(813, 33, false);
#line 24 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.MiddleName));

#line default
#line hidden
                EndContext();
                BeginContext(846, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(956, 44, false);
#line 27 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.MiddleName));

#line default
#line hidden
                EndContext();
                BeginContext(1000, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(1140, 30, false);
#line 33 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1170, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(1257, 31, false);
#line 36 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1288, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(1398, 42, false);
#line 39 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1440, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(1580, 25, false);
#line 45 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1605, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(1692, 26, false);
#line 48 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1718, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(1828, 37, false);
#line 51 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1865, 187, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2053, 27, false);
#line 59 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2080, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(2167, 28, false);
#line 62 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2195, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(2305, 39, false);
#line 65 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2344, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2484, 34, false);
#line 71 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2518, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(2605, 35, false);
#line 74 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2640, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(2750, 46, false);
#line 77 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.ConfirmEmail));

#line default
#line hidden
                EndContext();
                BeginContext(2796, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(2936, 29, false);
#line 83 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(2965, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(3052, 30, false);
#line 86 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(3082, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(3192, 41, false);
#line 89 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Website));

#line default
#line hidden
                EndContext();
                BeginContext(3233, 139, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
                EndContext();
                BeginContext(3373, 28, false);
#line 95 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.LabelFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3401, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
                EndContext();
                BeginContext(3488, 29, false);
#line 98 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.EditorFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3517, 109, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"pull-right col-md-8 text-danger\">\r\n                    ");
                EndContext();
                BeginContext(3627, 40, false);
#line 101 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Person\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.School));

#line default
#line hidden
                EndContext();
                BeginContext(3667, 143, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <button class=\"btn btn-primary\" type=\"submit\">Create</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3817, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CIS174_TestCoreApp.Models.CreatePersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563726f11a112b45b4be7e5065a616f1935ea854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Student), @"mvc.1.0.view", @"/Views/Student/Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Student.cshtml", typeof(AspNetCore.Views_Student_Student))]
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
#line 1 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 2 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563726f11a112b45b4be7e5065a616f1935ea854", @"/Views/Student/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CIS174_TestCoreApp.Models.StudentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
  
    ViewData["Title"] = "Student";

#line default
#line hidden
            BeginContext(102, 143, true);
            WriteLiteral("\r\n<h2>Students</h2>\r\n\r\n<h4>List of All Students</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n");
            EndContext();
#line 14 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
             if (ViewBag.AccessLevel >= 8)
            {

#line default
#line hidden
            BeginContext(304, 44, true);
            WriteLiteral("                <label>Hello Admin</label>\r\n");
            EndContext();
#line 17 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
            }

#line default
#line hidden
            BeginContext(363, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 18 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
            BeginContext(417, 52, true);
            WriteLiteral("                <div>\r\n                    <table>\r\n");
            EndContext();
#line 22 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                         if (ViewBag.AccessLevel <= 2)
                        {

#line default
#line hidden
            BeginContext(552, 105, true);
            WriteLiteral("                            <label>You do not have a sufficient access level to view this data.</label>\r\n");
            EndContext();
#line 25 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                        }
                        else if (ViewBag.AccessLevel >= 2 && ViewBag.AccessLevel <= 8)
                        {

#line default
#line hidden
            BeginContext(799, 133, true);
            WriteLiteral("                            <tr>\r\n                                <th> First Name: &nbsp;</th>\r\n                                <td> ");
            EndContext();
            BeginContext(933, 11, false);
#line 30 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                                Write(i.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(944, 112, true);
            WriteLiteral(" &nbsp;</td>\r\n                                <th> Last Name: &nbsp;</th>\r\n                                <td> ");
            EndContext();
            BeginContext(1057, 10, false);
#line 32 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                                Write(i.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 49, true);
            WriteLiteral(" &nbsp;</td>\r\n                            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1200, 133, true);
            WriteLiteral("                            <tr>\r\n                                <th> First Name: &nbsp;</th>\r\n                                <td> ");
            EndContext();
            BeginContext(1334, 11, false);
#line 39 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                                Write(i.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 112, true);
            WriteLiteral(" &nbsp;</td>\r\n                                <th> Last Name: &nbsp;</th>\r\n                                <td> ");
            EndContext();
            BeginContext(1458, 10, false);
#line 41 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                                Write(i.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1468, 108, true);
            WriteLiteral(" &nbsp;</td>\r\n                                <th> Grade: &nbsp;</th>\r\n                                <td> ");
            EndContext();
            BeginContext(1577, 7, false);
#line 43 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                                Write(i.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 49, true);
            WriteLiteral(" &nbsp;</td>\r\n                            </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                        }

#line default
#line hidden
            BeginContext(1660, 54, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n");
            EndContext();
#line 48 "C:\Users\Carl - Work\Desktop\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
            }

#line default
#line hidden
            BeginContext(1729, 49, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1778, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf3fe50a2be44a69c54735e0b5bcd2e", async() => {
                BeginContext(1800, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1816, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CIS174_TestCoreApp.Models.StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

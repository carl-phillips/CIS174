#pragma checksum "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Account\SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b989b5b55049c4939d4f7e034b13db27dc9d344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignedOut), @"mvc.1.0.view", @"/Views/Account/SignedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SignedOut.cshtml", typeof(AspNetCore.Views_Account_SignedOut))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b989b5b55049c4939d4f7e034b13db27dc9d344", @"/Views/Account/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a053c264e8544f2fed4e0e62d0d225d5d02dd7ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Account\SignedOut.cshtml"
  
    ViewData["Title"] = "Signed out";

#line default
#line hidden
            BeginContext(46, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(53, 17, false);
#line 5 "C:\Users\Carl - Work\Documents\CIS174\CIS174_TestCoreApp\Views\Account\SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(70, 57, true);
            WriteLiteral("</h2>\r\n<p>\r\n    You have successfully signed out.\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection20\BT-BlogManagement\BlogManagement\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "903ba07f34a3a9c08b4f5c7f392e8e83b1df167a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection20\BT-BlogManagement\BlogManagement\Views\_ViewImports.cshtml"
using BlogManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection20\BT-BlogManagement\BlogManagement\Views\_ViewImports.cshtml"
using BlogManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection20\BT-BlogManagement\BlogManagement\Views\_ViewImports.cshtml"
using BlogManagement.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection20\BT-BlogManagement\BlogManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"903ba07f34a3a9c08b4f5c7f392e8e83b1df167a", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a542d1d92077892cdf86c2a3748cedf6917229ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection20\BT-BlogManagement\BlogManagement\Views\Account\Index.cshtml"
  
    ViewBag.Title = "Home Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<hr />\r\n<h1 class=\"text-success text-center\">Welcome ");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection20\BT-BlogManagement\BlogManagement\Views\Account\Index.cshtml"
                                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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

#pragma checksum "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57bb20b221c017e7cfb3e9250c9207d3082a4a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\_ViewImports.cshtml"
using ValidationFormLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\_ViewImports.cshtml"
using ValidationFormLogin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57bb20b221c017e7cfb3e9250c9207d3082a4a1", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c706e6f3d3729ceabeb7c302e4a9c64ed266b0", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
  

    ViewBag.Title = "Login";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>  Login Form</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
 using (Html.BeginForm("Login", "User", FormMethod.Post, new { enctype = "multipart/form-data" }))

{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n\r\n        <div class=\"editor-label\">\r\n\r\n            ");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
       Write(Html.LabelFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
       Write(Html.EditorFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
       Write(Html.ValidationMessageFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"editor-field\">\r\n\r\n            ");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
       Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
       Write(Html.EditorFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <p><input type=\"submit\" value=\"Create\" /></p>\r\n\r\n    </fieldset>\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection13\Thuc-hanh\TH-ValidationFormLogin\ValidationFormLogin\Views\User\Login.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\Home\ViewDataTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843d6dee295a51a90cdb3b7f2f89b115e24a42af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewDataTest), @"mvc.1.0.view", @"/Views/Home/ViewDataTest.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\_ViewImports.cshtml"
using ViewExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\_ViewImports.cshtml"
using ViewExample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843d6dee295a51a90cdb3b7f2f89b115e24a42af", @"/Views/Home/ViewDataTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2d61fefee4f834cad391b45003cd09b56eeb0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewDataTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\Home\ViewDataTest.cshtml"
  
    var book = ViewData["Book"] as Book;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\Home\ViewDataTest.cshtml"
Write(ViewData["Greeting"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("!\r\n<br>\r\n\r\n<p>Book ID: ");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\Home\ViewDataTest.cshtml"
       Write(book.BookID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Book Name: ");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\Home\ViewDataTest.cshtml"
         Write(book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Author: ");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection12\Thuc-hanh\TH-ViewExample\ViewExample\Views\Home\ViewDataTest.cshtml"
      Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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

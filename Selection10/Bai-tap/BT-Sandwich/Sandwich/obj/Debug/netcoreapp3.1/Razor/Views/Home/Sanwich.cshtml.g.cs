#pragma checksum "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection10\Bai-tap\BT-Sandwich\Sandwich\Views\Home\Sanwich.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15098c66e877d49bce7f6289f44dd7273605f3f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sanwich), @"mvc.1.0.view", @"/Views/Home/Sanwich.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection10\Bai-tap\BT-Sandwich\Sandwich\Views\_ViewImports.cshtml"
using Sandwich;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection10\Bai-tap\BT-Sandwich\Sandwich\Views\_ViewImports.cshtml"
using Sandwich.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15098c66e877d49bce7f6289f44dd7273605f3f3", @"/Views/Home/Sanwich.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040ef0bf1aaa57c43c5dfcb54582e20f8a75d970", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sanwich : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SanwichModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection10\Bai-tap\BT-Sandwich\Sandwich\Views\Home\Sanwich.cshtml"
  
    ViewData["Title"] = "Sandwich Condiments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"display-4 text-primary\">");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection10\Bai-tap\BT-Sandwich\Sandwich\Views\Home\Sanwich.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br />\r\n<h3 class=\"text-danger\">Sandwich: ");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection10\Bai-tap\BT-Sandwich\Sandwich\Views\Home\Sanwich.cshtml"
                             Write(Model.Display());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SanwichModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
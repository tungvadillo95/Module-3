#pragma checksum "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99702585e9ef7276d4bf164bd815d8bfdfdcbaf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\_ViewImports.cshtml"
using CustomerManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\_ViewImports.cshtml"
using CustomerManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\_ViewImports.cshtml"
using CustomerManager.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99702585e9ef7276d4bf164bd815d8bfdfdcbaf3", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab196e19a1b24ff8669201b00187539b2f766c4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
  
    ViewBag.Title = "Create new customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1>CẬP NHẬT TÀI KHOẢN</h1>\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
     using (Html.BeginForm("Edit", "Home", "POST"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
                                ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row form-group\">\r\n            ");
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(e => e.ProvinceId, htmlAttributes: new { @class = "col-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-10\">\r\n                ");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
           Write(Html.DropDownListFor(e => e.ProvinceId, new SelectList(Model.Provinces, "id", "_name"), htmlAttributes: new { @class = "custom-select" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row form-group\">\r\n            ");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(e => e.Name, htmlAttributes: new { @class = "col-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
           Write(Html.TextBoxFor(e => e.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(e => e.Name, "", htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(e => e.Address, htmlAttributes: new { @class = "col-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
           Write(Html.TextBoxFor(e => e.Address, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(e => e.Address, "", htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(e => e.Phone, htmlAttributes: new { @class = "col-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
           Write(Html.TextBoxFor(e => e.Phone, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(e => e.Phone, "", htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Cập nhật</button>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99702585e9ef7276d4bf164bd815d8bfdfdcbaf39829", async() => {
                WriteLiteral("Hủy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\Selection16\TH-CustomerManager\CustomerManager\Views\Home\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterView> Html { get; private set; }
    }
}
#pragma warning restore 1591

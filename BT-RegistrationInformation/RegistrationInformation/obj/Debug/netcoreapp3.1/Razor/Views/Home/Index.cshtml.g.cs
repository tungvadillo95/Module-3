#pragma checksum "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\BT-RegistrationInformation\RegistrationInformation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab939b82743a0efd7b42ff519d9b50ee8c08934"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\BT-RegistrationInformation\RegistrationInformation\Views\_ViewImports.cshtml"
using RegistrationInformation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\BT-RegistrationInformation\RegistrationInformation\Views\_ViewImports.cshtml"
using RegistrationInformation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab939b82743a0efd7b42ff519d9b50ee8c08934", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e67f3b8aa83694587b6a1a69fef39d57a3b1aab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\BT-CODEGYM\Module-3\BT-RegistrationInformation\RegistrationInformation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            <label for=\"ddlProvince\">Tỉnh thành</label>\r\n            <select id=\"ddlProvince\" class=\"form-control\" onclick=\"getAllDistByPID(this.value)\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cab939b82743a0efd7b42ff519d9b50ee8c089344010", async() => {
                WriteLiteral("Chọn tỉnh thành");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"ddlDistrict\">Quận/Huyện</label>\r\n            <select id=\"ddlDistrict\" class=\"form-control\" onclick=\"getAllWardByPID(this.value)\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cab939b82743a0efd7b42ff519d9b50ee8c089345442", async() => {
                WriteLiteral("Chọn quận/huyện");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"ddlWard\">Phường/Xã</label>\r\n            <select id=\"ddlWard\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cab939b82743a0efd7b42ff519d9b50ee8c089346825", async() => {
                WriteLiteral("Chọn phường/xã");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </div>
        <div class=""col-md-12"">
            <div class=""text-success"">
                Bạn đang ở khu vực: <div id=""divResult""></div>
            </div>
        </div>
    </div>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        getAllProvinces();

        function getAllProvinces() {
            $.ajax({
                url: '/Service/GetAllProvinces',
                method: 'GET',
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    for (let i = 0; i < data.length; i++) {
                        console.log(data[i]);
                        $('#ddlProvince').append(`<option value='${data[i].id}'>${data[i]._name}</option>`);
                    }
                }

            });
        }

        function getAllDistByPID(id) {
            $.ajax({
                url: '/Service/GetAllDistrictByProvinceId/' + id,
                method: 'GET',
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    $('#ddlDistrict').html('<option value="""">Chọn quận/huyện</option>');
                    for (let i = 0; i < data.length; ");
                WriteLiteral(@"i++) {
                        $('#ddlDistrict').append(`<option value='${data[i].id}'>${data[i]._name}</option>`);
                    }
                }

            });
        }
        function getAllWardByPID(id) {
            $.ajax({
                url: '/Service/GetAllWardByDistrictId/' + id,
                method: 'GET',
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    $('#ddlWard').html('<option value="""">Chọn phường/xã</option>');
                    for (let i = 0; i < data.length; i++) {
                        $('#ddlWard').append(`<option value='${data[i].id}'>${data[i]._name}</option>`);
                    }
                }

            });
        }

        $(""#ddlWard"").on('change', function () {
            var provinceText = $(""#ddlProvince option:selected"").text();
            var districtText = $(""#ddlDistrict option:selected"").text();
            var wardText = $(""#ddl");
                WriteLiteral("Ward option:selected\").text();\r\n            var html = \"Tỉnh thành: \" + provinceText + \" \" + \"Quận huyện: \" + districtText + \" \" + \"Xã phường: \" + wardText;\r\n            $(\"#divResult\").html(html);\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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

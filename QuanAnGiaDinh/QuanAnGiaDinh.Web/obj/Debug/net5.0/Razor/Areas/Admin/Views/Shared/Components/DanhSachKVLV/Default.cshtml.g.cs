#pragma checksum "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\Components\DanhSachKVLV\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da1313324c1497e8b0e9d5379507f49250f8351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_DanhSachKVLV_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/DanhSachKVLV/Default.cshtml")]
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
#line 1 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\_ViewImports.cshtml"
using QuanAnGiaDinh.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\_ViewImports.cshtml"
using QuanAnGiaDinh.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da1313324c1497e8b0e9d5379507f49250f8351", @"/Areas/Admin/Views/Shared/Components/DanhSachKVLV/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0cb0d2f476d74bf00ba415c4a67b9b25d31bde", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_DanhSachKVLV_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<QuanAnGiaDinh.DTOs.KVLamViec>>
    {
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
#line 2 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\Components\DanhSachKVLV\Default.cshtml"
 foreach (var i in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da1313324c1497e8b0e9d5379507f49250f83513575", async() => {
#nullable restore
#line 4 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\Components\DanhSachKVLV\Default.cshtml"
                     Write(i.KVucLamViec);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 4 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\Components\DanhSachKVLV\Default.cshtml"
       WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\Components\DanhSachKVLV\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<QuanAnGiaDinh.DTOs.KVLamViec>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6949259b42920b297107b2911d297d1d15b5293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__NavigationBar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_NavigationBar.cshtml")]
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
#nullable restore
#line 1 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
using QuanAnGiaDinh.Web.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6949259b42920b297107b2911d297d1d15b5293", @"/Areas/Admin/Views/Shared/_NavigationBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0cb0d2f476d74bf00ba415c4a67b9b25d31bde", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__NavigationBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
  
	var className = "text-dark d-block text-decoration-none";

	var menu = new List<MenuItemVM>
{
		new MenuItemVM("Thống kê","fa-tachometer-alt", "dashboard"),
		new MenuItemVM("Kho Quán", "fa-newspaper", "Admin", "Index", "KhoQuan"),
		new MenuItemVM("Menu", "fa-drumstick", "", "Index", "Menu"),
		new MenuItemVM("Nhân Viên", "fa-user-alt", "", "Index", "NhanVien"),
		new MenuItemVM("DS Đặt Hàng", "fa-table", "", "ListCart", "HoatDong"),
	};

	var currentController = this.ViewContext.RouteData.Values["controller"].ToString();
	// var currentAction = this.ViewContext.RouteData.Values["action"].ToString();
	var active = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<nav class=\"border-right width-325px\">\r\n\t<div class=\"p-5\">\r\n");
            WriteLiteral("\t</div>\r\n\t<ul class=\"list-group list-group-flush mt-2\">\r\n\t\t<li class=\"list-group-item\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6949259b42920b297107b2911d297d1d15b52936438", async() => {
                WriteLiteral("<i class=\"fas fa-home\"></i>Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</li>\r\n\t</ul>\r\n\t<ul class=\"list-group list-group-flush mt-2\">\r\n");
#nullable restore
#line 30 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
         foreach (var item in menu)
		{
			if (item.ControllerName == currentController)
			{
				active = "active";
			}
			else
			{
				active = "";
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li");
            BeginWriteAttribute("class", " class=\"", 1213, "\"", 1244, 2);
            WriteAttributeValue("", 1221, "list-group-item", 1221, 15, true);
#nullable restore
#line 40 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue(" ", 1236, active, 1237, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 41 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                 if (item.Childs != null && item.Childs.Count > 0)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6949259b42920b297107b2911d297d1d15b52939346", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<i");
                BeginWriteAttribute("class", " class=\"", 1476, "\"", 1504, 3);
                WriteAttributeValue("", 1484, "fas", 1484, 3, true);
                WriteAttributeValue(" ", 1487, "fa-fw", 1488, 6, true);
#nullable restore
#line 45 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue(" ", 1493, item.Icon, 1494, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>&nbsp;<span>");
#nullable restore
#line 45 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                   Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1326, className, 1326, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            WriteLiteral("#");
#nullable restore
#line 43 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                          Write(item.IdAttr);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-target", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                       WriteLiteral(item.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                         WriteLiteral(item.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t<ul class=\"list-unstyled pl-4 collapse\"");
            BeginWriteAttribute("id", " id=\"", 1596, "\"", 1613, 1);
#nullable restore
#line 47 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue("", 1601, item.IdAttr, 1601, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 48 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                         foreach (var child in item.Childs)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"pt-2\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6949259b42920b297107b2911d297d1d15b529314583", async() => {
#nullable restore
#line 51 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                                                                                        Write(child.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1713, className, 1713, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                      WriteLiteral(child.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                                         WriteLiteral(child.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 53 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"

						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</ul>\r\n");
#nullable restore
#line 56 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6949259b42920b297107b2911d297d1d15b529318520", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<i");
                BeginWriteAttribute("class", " class=\"", 2030, "\"", 2058, 3);
                WriteAttributeValue("", 2038, "fas", 2038, 3, true);
                WriteAttributeValue(" ", 2041, "fa-fw", 2042, 6, true);
#nullable restore
#line 60 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue(" ", 2047, item.Icon, 2048, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>&nbsp;<span>");
#nullable restore
#line 60 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                   Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1905, className, 1905, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1921, item.IdAttr, 1921, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                             WriteLiteral(item.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                                                               WriteLiteral(item.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</li>\r\n");
#nullable restore
#line 65 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n\r\n</nav>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

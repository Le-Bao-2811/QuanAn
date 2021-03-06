#pragma checksum "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88471eb930510173cb3f44dee2bb4bcc3a7d2ff4"
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
#line 1 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\_ViewImports.cshtml"
using QuanAnGiaDinh.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\_ViewImports.cshtml"
using QuanAnGiaDinh.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
using DNews.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88471eb930510173cb3f44dee2bb4bcc3a7d2ff4", @"/Areas/Admin/Views/Shared/_NavigationBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2527546d75014aa1389460091bc255ec516028d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__NavigationBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
  
	var className = "text-dark d-block text-decoration-none";

	var menu = new List<MenuItemVM>
{
		new MenuItemVM("Dashboard","fa-tachometer-alt", "dashboard"),
		new MenuItemVM("Menu 1","fa-home","menu-1", "", "", "", new List<MenuItemVM>{
			new MenuItemVM("Menu item 1"),
			new MenuItemVM("Menu item 2"),
		}),
		new MenuItemVM("Menu kh??ng icon"),
		new MenuItemVM("B??i vi???t", "fa-newspaper", "", "Index", "Article"),
		new MenuItemVM("Danh m???c b??i vi???t", "fa-list", "", "List", "ArticleCategory"),
		new MenuItemVM("Danh m???c b??i vi???t (AJAX)", "fa-list", "", "Index", "ArticleCategory_Ajax")
	};

	var currentController = this.ViewContext.RouteData.Values["controller"].ToString();
	// var currentAction = this.ViewContext.RouteData.Values["action"].ToString();
	var active = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<nav class=\"border-right width-325px\">\r\n\t<div class=\"p-5\">\r\n");
            WriteLiteral("\t</div>\r\n\r\n\t<ul class=\"list-group list-group-flush mt-2\">\r\n");
#nullable restore
#line 30 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
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
            BeginWriteAttribute("class", " class=\"", 1151, "\"", 1182, 2);
            WriteAttributeValue("", 1159, "list-group-item", 1159, 15, true);
#nullable restore
#line 40 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue(" ", 1174, active, 1175, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 41 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                 if (item.Childs != null && item.Childs.Count > 0)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88471eb930510173cb3f44dee2bb4bcc3a7d2ff46358", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<i");
                BeginWriteAttribute("class", " class=\"", 1414, "\"", 1442, 3);
                WriteAttributeValue("", 1422, "fas", 1422, 3, true);
                WriteAttributeValue(" ", 1425, "fa-fw", 1426, 6, true);
#nullable restore
#line 45 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue(" ", 1431, item.Icon, 1432, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>&nbsp;<span>");
#nullable restore
#line 45 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
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
#line 43 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1264, className, 1264, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral("#");
#nullable restore
#line 43 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                          Write(item.IdAttr);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-target", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                       WriteLiteral(item.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
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
            BeginWriteAttribute("id", " id=\"", 1534, "\"", 1551, 1);
#nullable restore
#line 47 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue("", 1539, item.IdAttr, 1539, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 48 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                         foreach (var child in item.Childs)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"pt-2\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88471eb930510173cb3f44dee2bb4bcc3a7d2ff411539", async() => {
#nullable restore
#line 51 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
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
#line 51 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1651, className, 1651, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                      WriteLiteral(child.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                                         WriteLiteral(child.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 53 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"

						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</ul>\r\n");
#nullable restore
#line 56 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88471eb930510173cb3f44dee2bb4bcc3a7d2ff415434", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<i");
                BeginWriteAttribute("class", " class=\"", 1968, "\"", 1996, 3);
                WriteAttributeValue("", 1976, "fas", 1976, 3, true);
                WriteAttributeValue(" ", 1979, "fa-fw", 1980, 6, true);
#nullable restore
#line 60 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
WriteAttributeValue(" ", 1985, item.Icon, 1986, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>&nbsp;<span>");
#nullable restore
#line 60 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
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
#line 59 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1843, className, 1843, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
AddHtmlAttributeValue("", 1859, item.IdAttr, 1859, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                            WriteLiteral(item.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
                                                                                              WriteLiteral(item.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</li>\r\n");
#nullable restore
#line 64 "D:\hoaibao\DuAN\QuanAnGiaDinh\QuanAnGiaDinh.Web\Areas\Admin\Views\Shared\_NavigationBar.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n</nav>");
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

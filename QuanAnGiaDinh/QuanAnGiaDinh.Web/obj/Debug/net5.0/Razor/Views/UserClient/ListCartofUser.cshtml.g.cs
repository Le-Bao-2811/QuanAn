#pragma checksum "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "882ffd333a31c3a3dce29ab871d148b1dd565582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserClient_ListCartofUser), @"mvc.1.0.view", @"/Views/UserClient/ListCartofUser.cshtml")]
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
#line 1 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\_ViewImports.cshtml"
using QuanAnGiaDinh.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\_ViewImports.cshtml"
using QuanAnGiaDinh.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"882ffd333a31c3a3dce29ab871d148b1dd565582", @"/Views/UserClient/ListCartofUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0cb0d2f476d74bf00ba415c4a67b9b25d31bde", @"/Views/_ViewImports.cshtml")]
    public class Views_UserClient_ListCartofUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanAnGiaDinh.DTOs.DatHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/CssLiscCartofUser/css/checkout.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/CssLiscCartofUser/css/checkout.vender.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/CssLiscCartofUser/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/font-awesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tg-refresh", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("checkoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/Giaodien.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
  
	ViewData["Title"] = "ListCartofUser";
	Layout = "~/Views/Shared/_LayoutListCart.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("layoutliscart", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "882ffd333a31c3a3dce29ab871d148b1dd5655827889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "882ffd333a31c3a3dce29ab871d148b1dd5655829065", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "882ffd333a31c3a3dce29ab871d148b1dd56558210241", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "882ffd333a31c3a3dce29ab871d148b1dd56558211418", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<style>
	a,
	.radio__label__icon,
	.payment-due__price,
	.spinner--active,
	.icon-print,
	.alert--info,
	.order-summary-toggle__total-recap {
		color: #000000;
	}

	.input-checkbox:checked,
	.input-radio:checked {
		-webkit-box-shadow: 0 0 0 10px #000000 inset;
		box-shadow: 0 0 0 10px #000000 inset;
	}

	.product-thumbnail__quantity {
		background-color: #000000;
	}

	a:hover,
	a:focus,
	.icon-print:hover {
		color: #000000;
	}

	.field__input:focus,
	.select2-selection:focus,
	.select2-search__field:focus {
		border-color: #000000;
		box-shadow: 0 0 0 1px #000000;
	}

	.select2-container--default .select2-results__option--highlighted.select2-results__option--selectable {
		background-color: #000000;
	}

	.btn {
		background-color: #000000;
		border-color: #000000;
	}

		.btn:focus {
			outline-color: #000000;
		}

		.btn.disabled {
			background-color: #3F3F3F;
			border-color: #3F3F3F;
		}

		.btn:hover {
			background-color: #000000;
			border-color:");
            WriteLiteral(" #000000;\r\n\t\t}\r\n\r\n\t.btn {\r\n\t\tcolor: #FFFFFF;\r\n\t}\r\n\r\n\t.product-thumbnail__quantity {\r\n\t\tcolor: #FFFFFF;\r\n\t}\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "882ffd333a31c3a3dce29ab871d148b1dd56558213857", async() => {
                WriteLiteral("\r\n\t<header class=\"banner\">\r\n\t\t<div class=\"wrap\">\r\n\t\t\t<div class=\"logo logo--center\">\r\n\t\t\t\t<h1 class=\"shop__name\">\r\n\t\t\t\t\t<a href=\"/\">\r\n\t\t\t\t\t\tEvo Mobile\r\n\t\t\t\t\t</a>\r\n\t\t\t\t</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</header>\r\n");
#nullable restore
#line 91 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
     foreach (var item in Model)
	{


#line default
#line hidden
#nullable disable
                WriteLiteral(@"		<aside>
			<button class=""order-summary-toggle"" data-toggle=""#order-summary"" data-toggle-class=""order-summary--is-collapsed"">
				<span class=""wrap"">
					<span class=""order-summary-toggle__inner"">
						<span class=""order-summary-toggle__text expandable"">
							????n h??ng
						</span>
						<span class=""order-summary-toggle__total-recap"" data-bind=""getTextTotalPrice()""></span>
					</span>
				</span>
			</button>
		</aside>
		<div class=""content"">
			");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "882ffd333a31c3a3dce29ab871d148b1dd56558215130", async() => {
                    WriteLiteral(@"
				<input type=""hidden"" name=""_method"" value=""patch"" />
				<div class=""wrap"">
					<main class=""main"">
						<header class=""main__header"">
							<div class=""logo logo--center"">
								<h1 class=""shop__name"">
									<a href=""/"">
										????n h??ng
									</a>
								</h1>
							</div>
						</header>
						<div class=""main__content"">
							<article class=""animate-floating-labels row"">
								<div class=""col col--two"">
									<section class=""section"">

										<div class=""section__content"">
											<div class=""fieldset"">
												<div class=""field field--show-floating-label field--disabled"">
													<input name=""email"" type=""hidden""");
                    BeginWriteAttribute("value", " value=\"", 3137, "\"", 3159, 1);
#nullable restore
#line 128 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
WriteAttributeValue("", 3145, ViewBag.Email, 3145, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"field__input-wrapper\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label for=\"email\" class=\"field__label\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tT??n kh??ch h??ng\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<b>");
#nullable restore
#line 133 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                      Write(item.TenKH);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"field__input-wrapper\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label for=\"email\" class=\"field__label\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t?????a ch???\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<b>");
#nullable restore
#line 139 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                      Write(item.DiaChi);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"field__input-wrapper\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label for=\"email\" class=\"field__label\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tS??? ??i???n tho???i\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<b>");
#nullable restore
#line 145 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                      Write(item.SDT);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"field__input-wrapper\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label for=\"email\" class=\"field__label\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tT???ng s??? ti???n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<b>");
#nullable restore
#line 151 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                      Write(item.Sotien.ToString("#,0##"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" VN??</b>
													</div>
												</div>
											</div>
										</div>
									</section>

								</div>
							</article>
							<div class=""field__input-btn-wrapper field__input-btn-wrapper--vertical hide-on-desktop"">
								<button type=""submit"" class=""btn btn-checkout spinner"" data-bind-class=""{'spinner--active': isSubmitingCheckout}"" data-bind-disabled=""isSubmitingCheckout || isLoadingReductionCode"">
									<span class=""spinner-label"">?????T H??NG</span>
									<svg xmlns=""http://www.w3.org/2000/svg"" class=""spinner-loader"">
										<use href=""#spinner""></use>
									</svg>
								</button>
							</div>
							<div id=""common-alert"" data-tg-refresh=""refreshError"">
								<div class=""alert alert--danger hide-on-desktop"">
								</div>
							</div>
						</div>
					</main>
					<aside class=""sidebar"">
						<div class=""sidebar__header"">
							<h2 class=""sidebar__title"">
								????n h??ng (2 s???n ph???m)
							</h2>
						</div>
						<div class=""sidebar__c");
                    WriteLiteral(@"ontent"">
							<div id=""order-summary"" class=""order-summary order-summary--is-collapsed"">
								<div class=""order-summary__sections"">
									<div class=""order-summary__section order-summary__section--product-list order-summary__section--is-scrollable order-summary--collapse-element"">
										<table class=""product-table"">
											<caption class=""visually-hidden"">Chi ti???t ????n h??ng</caption>
											<thead class=""product-table__header"">
												<tr>
													<th>
														<span class=""visually-hidden"">???nh s???n ph???m</span>
													</th>
													<th>
														<span class=""visually-hidden"">M?? t???</span>
													</th>
													<th>
														<span class=""visually-hidden"">S??? l?????ng</span>
													</th>
													<th>
														<span class=""visually-hidden"">????n gi??</span>
													</th>
												</tr>
											</thead>
											<tbody>
");
#nullable restore
#line 203 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                 foreach (var cart in item.chiTietDonDatHangs)
												{

#line default
#line hidden
#nullable disable
                    WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<tr class=\"product\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td class=\"product__image\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product-thumbnail\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product-thumbnail__wrapper\" data-tg-static>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img");
                    BeginWriteAttribute("src", " src=\"", 6259, "\"", 6294, 2);
                    WriteAttributeValue("", 6265, "/img/menu/", 6265, 10, true);
#nullable restore
#line 209 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
WriteAttributeValue("", 6275, cart.menu.duongdan, 6275, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("alt", " alt=\"", 6295, "\"", 6301, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"product-thumbnail__image\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"product-thumbnail__quantity\">");
#nullable restore
#line 211 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                                                                     Write(cart.SoLuong);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<th class=\"product__description\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"product__description__name\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 216 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                           Write(cart.menu.ThucDon);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td class=\"product__quantity visually-hidden\"><em>S??? l?????ng:</em>");
#nullable restore
#line 219 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                                                                                   Write(cart.SoLuong);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td class=\"product__price\">");
#nullable restore
#line 220 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
                                                                              Write(cart.ThanhTien.ToString("#,0##"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" VN??</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 222 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
												}

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</aside>\r\n\t\t\t\t</div>\r\n\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
			<svg xmlns=""http://www.w3.org/2000/svg"" style=""display: none;"">
				<symbol id=""spinner"">
					<svg viewBox=""0 0 30 30"">
						<circle stroke=""currentColor"" stroke-width=""2"" fill=""none"" stroke-linecap=""round""
								stroke-dasharray=""85%"" cx=""50%"" cy=""50%"" r=""40%"">
							<animateTransform attributeName=""transform"" type=""rotate"" from=""0 15 15"" to=""360 15 15""
											  dur=""0.7s"" repeatCount=""indefinite"" />
						</circle>
					</svg>
				</symbol>
			</svg>
		</div>
");
#nullable restore
#line 247 "D:\hoaibao\DuAN\QuanAn\QuanAnGiaDinh\QuanAnGiaDinh.Web\Views\UserClient\ListCartofUser.cshtml"
	}

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-no-turbolink", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "882ffd333a31c3a3dce29ab871d148b1dd56558228016", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "882ffd333a31c3a3dce29ab871d148b1dd56558229056", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanAnGiaDinh.DTOs.DatHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591

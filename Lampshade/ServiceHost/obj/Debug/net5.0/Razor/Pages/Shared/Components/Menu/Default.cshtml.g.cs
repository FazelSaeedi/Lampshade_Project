#pragma checksum "D:\Projects\ASPNetCore\Lampshade_Project\Lampshade\ServiceHost\Pages\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70cc9af77cdb299d5fb96a6ebbb89c9b6d58813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Administration.Pages.Shared.Components.Menu.Pages_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Menu/Default.cshtml")]
namespace ServiceHost.Areas.Administration.Pages.Shared.Components.Menu
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70cc9af77cdb299d5fb96a6ebbb89c9b6d58813", @"/Pages/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0e07ca471ffd6fceb9fb5a1272d30c7f92445d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<!--====================  header area ====================-->
<div class=""header-area header-sticky"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  header wrapper  =======-->
                <div class=""header-wrapper d-none d-lg-flex"">
                    <!-- logo -->
                    <div class=""logo"">
                        <a href=""index.html"">
                            <img src=""assets/img/logo.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 526, "\"", 532, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                    </div>
                    <!-- menu wrapper -->
                    <div class=""navigation-menu-wrapper"">
                        <nav>
                            <ul>
                                <li>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70cc9af77cdb299d5fb96a6ebbb89c9b6d588135106", async() => {
                WriteLiteral("صفحه اصلی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </li>



                                <li class=""menu-item-has-children"">
                                    <a href=""blog-left-sidebar.html"">محصولات</a>
                                    <ul class=""sub-menu"">
                                        <li>
                                            <a href=""blog-left-sidebar.html"">دکوری</a>
                                        </li>
                                        <li>
                                            <a href=""blog-right-sidebar.html"">نگه دارنده</a>
                                        </li>

                                    </ul>
                                </li>

                                <li class=""menu-item-has-children"">
                                    <a href=""blog-left-sidebar.html"">مقالات</a>
                                    <ul class=""sub-menu"">
                                        <li>
                                            <a href=""blog-");
            WriteLiteral(@"left-sidebar.html"">گروه یک</a>
                                        </li>
                                        <li>
                                            <a href=""blog-right-sidebar.html"">گروه دو</a>
                                        </li>

                                    </ul>
                                </li>

                                <li>
                                    <a href=""contact.html"">تماس با ما </a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                    <!-- header icon -->
                    <div class=""header-icon-wrapper"">
                        <ul class=""icon-list"">
                            <li>
                                <a href=""javascript:void(0)"" id=""search-overlay-trigger"">
                                    <i class=""ion-ios-search-strong""></i>
                                </a>
                            </li>
         ");
            WriteLiteral(@"                   <li>
                                <div class=""header-cart-icon"">
                                    <a href=""#"" id=""minicart-trigger"">
                                        <i class=""ion-bag""></i>
                                        <span class=""counter"">3</span>
                                    </a>
                                    <!-- mini cart  -->
                                    <div class=""mini-cart"" id=""mini-cart"">
                                        <div class=""cart-items-wrapper ps-scroll"">
                                            <div class=""single-cart-item"">
                                                <a href=""javascript:void(0)"" class=""remove-icon"">
                                                    <i class=""ion-android-close""></i>
                                                </a>
                                                <div class=""image"">
                                                    <a href=""single-product.html"">");
            WriteLiteral("\r\n                                                        <img src=\"assets/img/products/product-1-80x106.jpg\"\r\n                                                             class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4130, "\"", 4136, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                </div>
                                                <div class=""content"">
                                                    <p class=""product-title"">
                                                        <a href=""single-product.html"">Cillum dolore furniture</a>
                                                    </p>
                                                    <p class=""count""><span>1 x </span> $402</p>
                                                </div>
                                            </div>
                                            <div class=""single-cart-item"">
                                                <a href=""javascript:void(0)"" class=""remove-icon"">
                                                    <i class=""ion-android-close""></i>
                                                </a>
                                                <div class=""ima");
            WriteLiteral(@"ge"">
                                                    <a href=""single-product.html"">
                                                        <img src=""assets/img/products/product-2-80x106.jpg""
                                                             class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 5438, "\"", 5444, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                </div>
                                                <div class=""content"">
                                                    <p class=""product-title"">
                                                        <a href=""single-product.html"">Lorem ipsum furniture</a>
                                                    </p>
                                                    <p class=""count""><span>1 x </span> $500</p>
                                                </div>
                                            </div>
                                            <div class=""single-cart-item"">
                                                <a href=""javascript:void(0)"" class=""remove-icon"">
                                                    <i class=""ion-android-close""></i>
                                                </a>
                                                <div class=""image");
            WriteLiteral(@""">
                                                    <a href=""single-product.html"">
                                                        <img src=""assets/img/products/product-3-80x106.jpg""
                                                             class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6744, "\"", 6750, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                </div>
                                                <div class=""content"">
                                                    <p class=""product-title"">
                                                        <a href=""single-product.html"">Cillum dolore tool</a>
                                                    </p>
                                                    <p class=""count""><span>1 x </span> $607</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""cart-calculation"">
                                            <table class=""table"">
                                                <tbody>
                                                    <tr>
                                                        <td class=""text-right"">Sub");
            WriteLiteral(@"-Total :</td>
                                                        <td class=""text-left"">$220.00</td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""text-right"">Eco Tax (-2.00) :</td>
                                                        <td class=""text-left"">$6.00</td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""text-right"">VAT (20%) :</td>
                                                        <td class=""text-left"">$44.00</td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""text-right"">Total :</td>
                                                        <td class=""text-left"">$270.00</td>
");
            WriteLiteral(@"                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                        <div class=""cart-buttons"">
                                            <a href=""cart.html"">VIEW CART</a>
                                            <a href=""checkout.html"">CHECKOUT</a>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""header-settings-icon"">
                                    <a href=""javascript:void(0)"" class=""header-settings-trigger""
                                       id=""header-settings-trigger"">
                                        <div class=""setting-button"">
                                            <span></span>
          ");
            WriteLiteral(@"                                  <span></span>
                                            <span></span>
                                        </div>
                                    </a>

                                    <!-- settings menu -->
                                    <div class=""settings-menu-wrapper"" id=""settings-menu-wrapper"">
                                        <div class=""single-settings-block"">
                                            <h4 class=""title"">پروفایل من</h4>
                                            <ul>
                                                <li>
                                                    <a href=""login-register.html"">ثبت نام</a>
                                                </li>
                                                <li>
                                                    <a href=""login-register.html"">ورود</a>
                                                </li>
                                            </ul>
  ");
            WriteLiteral("                                      </div>\r\n\r\n");
            WriteLiteral(@"

                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <!--=======  End of header wrapper  =======-->
                <!--=======  mobile navigation area  =======-->

                <div class=""header-mobile-navigation d-block d-lg-none"">
                    <div class=""row align-items-center"">
                        <div class=""col-6 col-md-6"">
                            <div class=""header-logo"">
                                <a href=""index.html"">
                                    <img src=""assets/img/logo.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 13468, "\"", 13474, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                        <div class=""col-6 col-md-6"">
                            <div class=""mobile-navigation text-right"">
                                <div class=""header-icon-wrapper"">
                                    <ul class=""icon-list justify-content-end"">
                                        <li>
                                            <div class=""header-cart-icon"">
                                                <a href=""cart.html"">
                                                    <i class=""ion-bag""></i>
                                                    <span class=""counter"">3</span>
                                                </a>
                                            </div>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"" class=""mobile-men");
            WriteLiteral(@"u-icon""
                                               id=""mobile-menu-trigger"">
                                                <i class=""fa fa-bars""></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!--=======  End of mobile navigation area  =======-->

            </div>
        </div>
    </div>
</div>
<!--====================  End of header area  ====================-->




<div class=""offcanvas-mobile-menu"" id=""offcanvas-mobile-menu"">
    <a href=""javascript:void(0)"" class=""offcanvas-menu-close"" id=""offcanvas-menu-close-trigger"">
        <i class=""ion-android-close""></i>
    </a>

    <div class=""offcanvas-wrapper"">

        <div class=""offcanvas-inner-content"">
            <div class=""offcanvas-mobile-search-are");
            WriteLiteral("a\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70cc9af77cdb299d5fb96a6ebbb89c9b6d5881320223", async() => {
                WriteLiteral("\r\n                    <input type=\"search\" placeholder=\"جستجو\">\r\n                    <button type=\"submit\">\r\n                        <i class=\"fa fa-search\"></i>\r\n                    </button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <nav class=\"offcanvas-navigation\">\r\n                <ul>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 15893, "\"", 15901, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70cc9af77cdb299d5fb96a6ebbb89c9b6d5881322056", async() => {
                WriteLiteral("صفحه اصلی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>

                    <li class=""menu-item-has-children"">
                        <a href=""#"">محصولات</a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""blog-left-sidebar.html"">دکوری</a>
                            </li>
                            <li>
                                <a href=""blog-right-sidebar.html"">نگه دارنده</a>
                            </li>
                        </ul>
                    </li>

                    <li class=""menu-item-has-children"">
                        <a href=""#"">مقالات</a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""blog-left-sidebar.html"">گروه مقاله 1</a>
                            </li>
                            <li>
                                <a href=""blog-right-sidebar.html"">گروه مقاله 2</a>
                            </li>
                        </u");
            WriteLiteral("l>\r\n                    </li>\r\n                    \r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 17063, "\"", 17071, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70cc9af77cdb299d5fb96a6ebbb89c9b6d5881324540", async() => {
                WriteLiteral("تماس با ما ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
                

            </nav>

            <div class=""offcanvas-settings"">
                <nav class=""offcanvas-navigation"">
                    <ul>
                        <li class=""menu-item-has-children"">
                            <a href=""#"">پروفایل من </a>
                            <ul class=""sub-menu"">
                                <li>
                                    <a href=""login-register.html"">ثبت نام</a>
                                </li>
                                <li>
                                    <a href=""login-register.html"">ورود</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </nav>
            </div>

            <div class=""offcanvas-widget-area"">
                <div class=""off-canvas-contact-widget"">
                    <div class=""header-contact-info"">
                        <ul ");
            WriteLiteral(@"class=""header-contact-info__list"">
                            <li>
                                <i class=""ion-android-phone-portrait""></i> <a href=""tel://09366285660"">
                                    (1245) 2456
                                    012
                                </a>
                            </li>
                            <li>
                                <i class=""ion-android-mail""></i> <a href=""mailto:info@yourdomain.com"">FazelSaeedi@iran.ir</a>
                            </li>
                        </ul>
                    </div>
                </div>
                <!--Off Canvas Widget Social Start-->
                <div class=""off-canvas-widget-social"">
                    <a href=""#"" title=""Facebook"">
                        <i class=""fa fa-facebook""></i>
                    </a>
                    <a href=""#"" title=""Twitter"">
                        <i class=""fa fa-twitter""></i>
                    </a>
                    <a href=""#"" ");
            WriteLiteral(@"title=""LinkedIn"">
                        <i class=""fa fa-linkedin""></i>
                    </a>
                    <a href=""#"" title=""Youtube"">
                        <i class=""fa fa-youtube-play""></i>
                    </a>
                    <a href=""#"" title=""Vimeo"">
                        <i class=""fa fa-vimeo-square""></i>
                    </a>
                </div>
                <!--Off Canvas Widget Social End-->
            </div>
        </div>
    </div>

</div>");
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

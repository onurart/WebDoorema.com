#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbd58360f54c91e11f142e2edd2b378e253a017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\_ViewImports.cshtml"
using WebDooreme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\_ViewImports.cshtml"
using WebDooreme.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cbd58360f54c91e11f142e2edd2b378e253a017", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group form-inline signup send-mail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/musteri-mail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer class=""footer-container typefooter-4"">
    <!-- Footer Top Container -->
    <section class=""footer-top"">
        <div class=""container"">
            <div class=""module newsletter-footer4"">
                <div class=""newsletter"">
                    <div class=""title-block"">
                        <div class=""promotext"">En son ürün trendlerini ve sektör haberlerini doğrudan gelen kutunuza teslim edin.</div>
                    </div>
                    <div class=""block_content"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbd58360f54c91e11f142e2edd2b378e253a0175168", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <div class=\"input-box\">\r\n                                    <input type=\"email\" name=\"EmailMessage\" placeholder=\"E-mail adresinizi yazınız.\"");
                BeginWriteAttribute("value", " value=\"", 900, "\"", 908, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" id=""txtemail""  size=""55"" required>
                                </div>
                                <div class=""subcribe"">
                                    <button class=""btn btn-primary btn-default font-title"" type=""submit""  name=""submit"" style=""float:right"">
                                        Kayıt ol
                                    </button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!--/.modcontent-->
                </div>
            </div>
        </div>
    </section>
    <!-- /Footer Top Container -->
    <section class=""footer-middle "">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12 col_4202  col-style"">
                    <div class=""infos-footer box-footer"">
                        <div class=""module"">
                            <h3 class=""modtitle"">İletişim</h3>
                            <ul  style=""margin-left:15px"">
                                <li class=""adres"">
                                    <i class=""fa fa-map-marker"">1</i>Defterdar Mahallesi Demirkapı Keresteciler Sitesi
                                    Çaycılar Sokak No: 2
                                    <br> Eyüp/İstanbul/Türkiye
                                   
                                </li>
                                <li class=""mail"">
 ");
            WriteLiteral(@"                                   <a href=""mailto:ema@emacelikkapi.com=?subject = Feedback&body = Message"">
                                        <i class=""fa fa-envelope"">2</i>ema@emacelikkapi.com
                                    </a>
                                </li>
                                <li class=""mail"" style=""margin-top:20px"">
                                    <a href=""mailto:ema@emacelikkapi.com=?subject = Feedback&body = Message"">
                                        <i class=""fa fa-mobile""></i>  +90.212.523.02.53-59
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12 col_bko7  col-style"">
                    <div class=""box-account box-footer"">
                        <div class=""module clearfix"">
                            <h3 class=""modtitle"">Ürünlerimiz<");
            WriteLiteral("/h3>\r\n                            <div class=\"modcontent\">\r\n                                <ul class=\"menu\">\r\n");
#nullable restore
#line 66 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3719, "\"", 3810, 4);
            WriteAttributeValue("", 3726, "/urun/ana-kategori/", 3726, 19, true);
#nullable restore
#line 68 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3745, UrlExtension.FriendlyUrl(Url,item.CategoryName), 3745, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3793, "/", 3793, 1, true);
#nullable restore
#line 68 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3794, item.CategoryId, 3794, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3811, "\"", 3837, 1);
#nullable restore
#line 68 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3819, item.CategoryName, 3819, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 3838, "\"", 3862, 1);
#nullable restore
#line 68 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3844, item.CategoryName, 3844, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3863, "\"", 3887, 1);
#nullable restore
#line 68 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3869, item.CategoryName, 3869, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                                                                                                                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 69 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Footer\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12 col_6urb  col-style"">
                    <div class=""box-information box-footer"">
                        <div class=""module clearfix"">
                            <h3 class=""modtitle"">Menü </h3>
                            <div class=""modcontent"">
                                <ul class=""menu"">
                                    <li>
                                        <a href=""/kurumsal"" title=""kurumsal"" ref=""kurumsal"" alt=""kurumsal"">Kurumsal</a>
                                    </li>
                                    <li>
                                        <a href=""/teknik-bilgi"" title=""Teknik Bilgi"" ref=""Teknik Bilgi"" alt=""Teknik Bilgi"">Teknik Bilgi</a>
                                    </li>
                                    <li>
                    ");
            WriteLiteral(@"                    <a href=""/proje-yonetimi"" title=""Proje Yönetimi"" ref=""Proje Yönetimi"" alt=""Proje Yönetimi"">Proje Yönetimi</a>
                                    </li>
                                    <li>
                                        <a href=""/referanslar"" title=""Referanslar"" ref=""Referanslar"" alt=""Referanslar"">Referanslar</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12 col_3d8g  col-style"">
                    <div class=""box-service box-footer"">
                        <div class=""module clearfix"">
                            <h3 class=""modtitle"">Menü </h3>
                            <div class=""modcontent"">
                                <ul class=""menu"">
                                    <li>
                                        <a href=""/belgeler"" t");
            WriteLiteral(@"itle=""Referanslar"" ref=""Referanslar"" alt=""Referanslar"">Belgeler</a>
                                    </li>
                                    <li>
                                        <a href=""/blog"" title=""Blog"" ref=""Blog"" alt=""Blog"">Blog</a>
                                    </li>
                                    <li>
                                        <a href=""/soru-cevap"" title=""Soru/Cevap"" ref=""Soru/Cevap"" alt=""Soru/Cevap"">Soru/Cevap</a>
                                    </li>
                                    <li>
                                        <a href=""/iletisim"" title=""İletişim"" ref=""İletişim"" alt=""İletişim"">İletişim</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row middle2 "">
                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12 col-style"">
       ");
            WriteLiteral("             <div");
            BeginWriteAttribute("class", " class=\"", 7046, "\"", 7054, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <h3 class=""modtitle""></h3>
                        <ul>
                            <li>
                                <a title=""App Store"" href=""#"">
                                </a>
                            </li>
                            <li>
                                <a title=""App Store"" href=""#"">
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                    <div class=""socials-w module"">
                        <h3 class=""modtitle"">BİZİ TAKİP EDİN </h3>
                        <ul class=""socials"">
");
            WriteLiteral(@"                            <li class=""google_plus"">
                                <a class=""_blank"" href=""https://instagram.com/dooremacelikkapi?igshid=YmMyMTA2M2Y="" target=""_blank"" rel=""nofollow""><i class=""fa fa-instagram""></i></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""categories-footer"">
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d188.09479819864816!2d28.92532761214074!3d41.03582687558803!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caba6d937bffff%3A0x6c25c46baa7b9b98!2sDoorema!5e0!3m2!1str!2str!4v1662734725891!5m2!1str!2str"" width=""100%"" height=""350"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 8963, "\"", 8981, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy""></iframe>
            </div>
        </div>
    </section>
    <!-- Footer Bottom Container -->
    <section class=""footer-bottom "">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-7 col-sm-12 col-xs-12 copyright-w"">
                    <div class=""copyright"">
                        Tüm Hakları <a href=""http://www.doorema.com.tr"" target=""_blank"">Doorema'ya  Aittir...</a>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-5 col-sm-12 col-xs-12 payment-w"">
                </div>
            </div>
        </div>
    </section>
    <!-- /Footer Bottom Container -->
    <!--Back To Top-->
    <div class=""back-to-top""><i class=""fa fa-angle-up""></i></div>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

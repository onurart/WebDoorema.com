#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ee285f0402af450e1b077547cae02383d12c93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DealsDay_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DealsDay/Default.cshtml")]
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
#line 1 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\_ViewImports.cshtml"
using WebDooreme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\_ViewImports.cshtml"
using WebDooreme.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ee285f0402af450e1b077547cae02383d12c93", @"/Views/Shared/Components/DealsDay/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_DealsDay_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("287"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("210"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-lg-2 col-md-12 col-sm-12 col-xs-12 box-left"">
    <!-- Deals -->
    <div class=""module deals-layout4"" style=""border-radius: 27px 45px 27px 28px "">
        <h3 title=""Doorema Proje Kapıları"" ref=""Doorema Proje Kapıları"" alt=""Proje Çelik Kapıları"" class=""modtitle""><span title=""Doorema Günün Fırsatları"" ref=""Doorema Günün Fırsatları"" alt=""Günün Fırsatları"">Günün Fırsatları</span></h3>
        <div class=""modcontent"">
            <div class=""so-deal style2"">
");
            WriteLiteral(@"                <div class=""yt-content-slider extraslider-inner products-list"" data-rtl=""yes"" data-pagination=""no"" data-autoplay=""no"" data-delay=""4"" data-speed=""0.6"" data-margin=""30"" data-items_column0=""6"" data-items_column1=""3"" data-items_column2=""2"" data-items_column3=""2"" data-items_column4=""1"" data-arrows=""yes"" data-lazyload=""yes"" data-loop=""no"" data-buttonpage=""top"">
");
#nullable restore
#line 11 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
                     foreach (var item in Model.Where(m => m.CategoryId == 8))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item product-layout product-grid2"">
                            <div class=""product-thumb transition product-item-container"">
                                <div class=""left-block"">
                                    <div class=""product-image-container"">
                                        <div class=""image"">
");
#nullable restore
#line 22 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
                                              
                                                var imageSrcm = item.StockCode.ToLower();
                                                var strImagem = imageSrcm + ".jpg";
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"#\" target=\"_self\" title=\"product\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ee285f0402af450e1b077547cae02383d12c936712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2465, "~/ProductImages/ProductL/", 2465, 25, true);
#nullable restore
#line 27 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
AddHtmlAttributeValue("", 2490, strImagem, 2490, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2534, "Doorema", 2534, 7, true);
            AddHtmlAttributeValue(" ", 2541, "Günün", 2542, 6, true);
            AddHtmlAttributeValue(" ", 2547, "Fırsatları", 2548, 11, true);
#nullable restore
#line 27 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
AddHtmlAttributeValue(" ", 2558, item.ProductName, 2559, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ref", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2583, "Doorema", 2583, 7, true);
            AddHtmlAttributeValue(" ", 2590, "Günün", 2591, 6, true);
            AddHtmlAttributeValue(" ", 2596, "Fırsatları", 2597, 11, true);
#nullable restore
#line 27 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
AddHtmlAttributeValue(" ", 2607, item.ProductName, 2608, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
AddHtmlAttributeValue("", 2632, item.ProductName, 2632, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <!--quickview-->
                                        <div class=""so-quickview"">
                                            <a class=""btn-button quickview quickview_handler visible-lg""");
            BeginWriteAttribute("href", " href=\"", 3004, "\"", 3086, 4);
            WriteAttributeValue("", 3011, "/urun/detay/", 3011, 12, true);
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
WriteAttributeValue("", 3023, UrlExtension.FriendlyUrl(Url,item.ProductName), 3023, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3070, "/", 3070, 1, true);
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
WriteAttributeValue("", 3071, item.StockCode, 3071, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3087, "\"", 3137, 4);
            WriteAttributeValue("", 3095, "Doorema", 3095, 7, true);
            WriteAttributeValue(" ", 3102, "Günün", 3103, 6, true);
            WriteAttributeValue(" ", 3108, "Fırsatları", 3109, 11, true);
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
WriteAttributeValue(" ", 3119, item.ProductName, 3120, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 3138, "\"", 3186, 4);
            WriteAttributeValue("", 3144, "Doorema", 3144, 7, true);
            WriteAttributeValue(" ", 3151, "Günün", 3152, 6, true);
            WriteAttributeValue(" ", 3157, "Fırsatları", 3158, 11, true);
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
WriteAttributeValue(" ", 3168, item.ProductName, 3169, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3187, "\"", 3210, 1);
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
WriteAttributeValue("", 3193, item.ProductName, 3193, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  data-fancybox-type=""iframe"">
                                                <i class=""fa fa-eye""></i>
                                            </a>
                                        </div>
                                        <!--end quickview-->
                                    </div>
                                </div>
");
            WriteLiteral("                                <!--countdown box-->\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 69 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\DealsDay\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- End Deals -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7566c28917601e84cd9ca760617e6256af9eeb42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RelatedProduct_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RelatedProduct/Default.cshtml")]
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
#line 1 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7566c28917601e84cd9ca760617e6256af9eeb42", @"/Views/Shared/Components/RelatedProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_RelatedProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-1 img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-2 img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
Write(ViewBag.viewkategori);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""content"" class=""col-md-12 col-sm-8"">
    <div class=""related titleLine products-list grid module "">
        <h3 class=""modtitle"" title=""Benzer Ürünler Products"" ref=""Benzer Ürünler Products"" alt=""Benzer Ürünler Products"">Benzer Ürünler Products  </h3>
        <hr />
        <div class=""releate-products yt-content-slider products-list"" data-rtl=""no"" data-loop=""yes"" data-autoplay=""no"" data-autoheight=""no"" data-autowidth=""no"" data-delay=""4"" data-speed=""0.6"" data-margin=""30"" data-items_column0=""5"" data-items_column1=""3"" data-items_column2=""3"" data-items_column3=""2"" data-items_column4=""1"" data-arrows=""yes"" data-pagination=""no"" data-lazyload=""yes"" data-hoverpause=""yes"">
");
#nullable restore
#line 9 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""item"">
                    <div class=""item-inner product-layout transition product-grid"">
                        <div class=""product-item-container"">
                            <div class=""left-block"">
                                <div class=""product-image-container second_img"">
");
#nullable restore
#line 17 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
                                      
                                        var imageSrcm = item.StockCode.ToLower();
                                        var strImagem = imageSrcm + ".jpg";
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1414, "\"", 1494, 4);
            WriteAttributeValue("", 1421, "/urun/detay/", 1421, 12, true);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 1433, UrlExtension.FriendlyUrl(Url,item.StockCode), 1433, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1478, "/", 1478, 1, true);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 1479, item.StockCode, 1479, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_self\"");
            BeginWriteAttribute("title", " title=\"", 1510, "\"", 1533, 1);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 1518, item.StockCode, 1518, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7566c28917601e84cd9ca760617e6256af9eeb427598", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1587, "~/ProductImages/ProductL/", 1587, 25, true);
#nullable restore
#line 22 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1612, strImagem, 1612, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1660, item.StockCode, 1660, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ref", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1682, item.StockCode, 1682, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1704, item.StockCode, 1704, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7566c28917601e84cd9ca760617e6256af9eeb4210733", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1773, "~/ProductImages/ProductL/", 1773, 25, true);
#nullable restore
#line 23 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1798, strImagem, 1798, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1846, item.StockCode, 1846, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ref", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1868, item.StockCode, 1868, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
AddHtmlAttributeValue("", 1890, item.StockCode, 1890, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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

                                <div class=""button-group so-quickview cartinfo--left"">
                                    <button type=""button"" class=""addToCart btn-button"" title=""Add to cart"" onclick=""cart.add('60 ');"">
                                        <i class=""fa fa-shopping-basket""></i>
                                        <span>Add to cart </span>
                                    </button>
                                    <button type=""button"" class=""wishlist btn-button"" title=""Add to Wish List"" onclick=""wishlist.add('60');"">
                                        <i class=""fa fa-heart""></i><span>Add to Wish List</span>
                                    </button>
                                    <button type=""button"" class=""compare btn-button"" title=""Compare this Product "" onclick=""compare.add('60');"">
                                        <i class=""fa fa-refresh""></i><span>Compare this");
            WriteLiteral(@" Product</span>
                                    </button>
                                    <!--quickview-->
                                    <a class=""iframe-link btn-button quickview quickview_handler visible-lg"" href=""quickview.html"" title=""Quick view"" data-fancybox-type=""iframe""><i class=""fa fa-eye""></i><span>Quick view</span></a>
                                    <!--end quickview-->
                                </div>
                            </div>
                            <div class=""right-block"">
                                <div class=""caption"">

                                    <div class=""rating"">
                                        <span class=""fa fa-stack""><i class=""fa fa-star fa-stack-2x""></i></span>
                                        <span class=""fa fa-stack""><i class=""fa fa-star fa-stack-2x""></i></span>
                                        <span class=""fa fa-stack""><i class=""fa fa-star fa-stack-2x""></i></span>
                               ");
            WriteLiteral(@"         <span class=""fa fa-stack""><i class=""fa fa-star fa-stack-2x""></i></span>
                                        <span class=""fa fa-stack""><i class=""fa fa-star fa-stack-2x""></i></span>

                                    </div>
                                    <h4><a href=""product.html""");
            BeginWriteAttribute("title", " title=\"", 4258, "\"", 4281, 1);
#nullable restore
#line 54 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 4266, item.StockCode, 4266, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_self\">");
#nullable restore
#line 54 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
                                                                                                 Write(item.StockCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <div class=\"list-block\" style=\"font-size:15px; font-weight:700; text-transform:uppercase\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4494, "\"", 4574, 4);
            WriteAttributeValue("", 4501, "/urun/detay/", 4501, 12, true);
#nullable restore
#line 56 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 4513, UrlExtension.FriendlyUrl(Url,item.StockCode), 4513, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4558, "/", 4558, 1, true);
#nullable restore
#line 56 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 4559, item.StockCode, 4559, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_self\"");
            BeginWriteAttribute("title", " title=\"", 4590, "\"", 4613, 1);
#nullable restore
#line 56 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 4598, item.StockCode, 4598, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <button class=\"addToCart btn-button btn btn-danger\" type=\"button\"");
            BeginWriteAttribute("title", " title=\"", 4726, "\"", 4749, 1);
#nullable restore
#line 57 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
WriteAttributeValue("", 4734, item.StockCode, 4734, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                ÜRÜN DETAYI
                                            </button>
                                        </a>
                     
                                        <button class=""wishlist btn-button btn btn-danger"" type=""button"" title=""Beğen"" onclick=""wishlist.add('101');"">
                                            <i class=""fa fa-heart""></i>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 71 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\RelatedProduct\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
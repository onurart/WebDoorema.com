#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160fd144d036bff8c3622f68442b93a3653d9935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchList), @"mvc.1.0.view", @"/Views/Home/SearchList.cshtml")]
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
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160fd144d036bff8c3622f68442b93a3653d9935", @"/Views/Home/SearchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SearchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("239"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-1 img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-2 img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("res layout-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 4 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
      Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 129, "\"", 156, 1);
#nullable restore
#line 5 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 139, ViewBag.keywords, 139, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 190, "\"", 220, 1);
#nullable restore
#line 6 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 200, ViewBag.description, 200, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "160fd144d036bff8c3622f68442b93a3653d99356026", async() => {
                WriteLiteral(@"
    <div id=""wrapper"" class=""wrapper-fluid banners-effect-5"">
        <div class=""main-container container"">
            <ul class=""breadcrumb"">
                <li><a href=""/anasayfa""><i class=""fa fa-home""></i></a></li>
                <li><a href=""#"">Arama Listesi</a></li>
            </ul>
            <div class=""row"">
                <aside class=""col-sm-4 col-md-3 content-aside"" id=""column-left"">
                    ");
#nullable restore
#line 17 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
               Write(await Component.InvokeAsync("ProductCategoriesMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </aside>\r\n                <div id=\"content\" class=\"col-md-9 col-sm-8\">\r\n                    <div class=\"products-category\">\r\n                        <div class=\"products-list row nopadding-xs so-filter-gird grid\">\r\n");
#nullable restore
#line 22 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
                             if (Model.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<div class=""product-layout col-lg-14 col-md-3 col-sm-6 col-xs-12"">
                                        <div class=""product-item-container"">
                                            <div class=""left-block"">
                                                <div class=""product-image-container second_img"">
                                                    <a");
                BeginWriteAttribute("href", " href=\"", 1522, "\"", 1602, 4);
                WriteAttributeValue("", 1529, "/urun/detay/", 1529, 12, true);
#nullable restore
#line 29 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 1541, UrlExtension.FriendlyUrl(Url,item.StockCode), 1541, 45, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1586, "/", 1586, 1, true);
#nullable restore
#line 29 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 1587, item.StockCode, 1587, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_self\"");
                BeginWriteAttribute("title", " title=\"", 1618, "\"", 1651, 1);
#nullable restore
#line 29 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 1626, item.StockCode.ToUpper(), 1626, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 30 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
                                                          
                                                            var imageSrcm = item.StockCode.ToLower();
                                                            var strImagem = imageSrcm + ".jpg";
                                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "160fd144d036bff8c3622f68442b93a3653d99359929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2040, "~/ProductImages/ProductL/", 2040, 25, true);
#nullable restore
#line 34 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
AddHtmlAttributeValue("", 2065, strImagem, 2065, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
AddHtmlAttributeValue("", 2124, item.ProductName, 2124, 17, false);

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
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "160fd144d036bff8c3622f68442b93a3653d993512179", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2211, "~/ProductImages/ProductL/", 2211, 25, true);
#nullable restore
#line 35 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
AddHtmlAttributeValue("", 2236, strImagem, 2236, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
AddHtmlAttributeValue("", 2295, item.ProductName, 2295, 17, false);

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
                                                <div class=""box-label""> <span class=""label-product""> </span></div>
                                                <div class=""button-group so-quickview cartinfo--left"">
");
                WriteLiteral("                                                    <!--quickview-->\r\n                                                    <a class=\"btn-button quickview quickview_handler visible-lg\"");
                BeginWriteAttribute("href", " href=\"", 3537, "\"", 3617, 4);
                WriteAttributeValue("", 3544, "/urun/detay/", 3544, 12, true);
#nullable restore
#line 47 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 3556, UrlExtension.FriendlyUrl(Url,item.StockCode), 3556, 45, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3601, "/", 3601, 1, true);
#nullable restore
#line 47 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 3602, item.StockCode, 3602, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3618, "\"", 3643, 1);
#nullable restore
#line 47 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 3626, item.ProductName, 3626, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" data-fancybox-type=""iframe""><i class=""fa fa-eye""></i><span>Detay</span></a>
                                                    <!--end quickview-->
                                                </div>
                                            </div>
                                            <div class=""right-block"">
                                                <div class=""caption"">
");
                WriteLiteral("                                                    <h4><a");
                BeginWriteAttribute("href", " href=\"", 4921, "\"", 5001, 4);
                WriteAttributeValue("", 4928, "/urun/detay/", 4928, 12, true);
#nullable restore
#line 60 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 4940, UrlExtension.FriendlyUrl(Url,item.StockCode), 4940, 45, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4985, "/", 4985, 1, true);
#nullable restore
#line 60 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 4986, item.StockCode, 4986, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 5002, "\"", 5027, 1);
#nullable restore
#line 60 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
WriteAttributeValue("", 5010, item.ProductName, 5010, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_self\">");
#nullable restore
#line 60 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
                                                                                                                                                                                Write(item.StockCode.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h4>\r\n");
                WriteLiteral("                                                    <div class=\"list-block\">\r\n");
                WriteLiteral(@"                                                        <!--quickview-->
                                                        <!--<a class=""iframe-link btn-button quickview quickview_handler visible-lg"" href=""quickview.html"" title=""Quick view"" data-fancybox-type=""iframe""><i class=""fa fa-eye""></i></a>-->
                                                        <!--end quickview-->
                                                        <!--</div>-->
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
");
#nullable restore
#line 83 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""product-layout col-lg-14 col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""product-item-container"">
                                        <p class=""text-danger"">Aradığınız isimde/kodda ürün bulunamadı!</p>
                                    </div>
                                </div>
");
#nullable restore
#line 92 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\SearchList.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ab6494d72af4e4c5b6ecce99919b78360acae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Discount_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Discount/Default.cshtml")]
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
#line 1 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
using WebDooreme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ab6494d72af4e4c5b6ecce99919b78360acae1", @"/Views/Shared/Components/Discount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Discount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" object-fit: contain;object-position: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("320"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""so-categories custom-slidercates module clearfix"" style=""border-radius:30px 30px 30px 30px"">
    <h3 class=""modtitle""><span> Kampanya </span></h3>
    <div class=""modcontent"" style=""border-radius:30px 30px 30px 30px"">
        <div class=""cat-wrap theme3 font-title yt-content-slider"" data-rtl=""yes"" data-autoplay=""yes"" data-autoheight=""no"" data-delay=""4"" data-speed=""0.1"" data-margin=""30"" data-items_column0=""4"" data-items_column1=""4"" data-items_column2=""3"" data-items_column3=""2"" data-items_column4=""1"" data-arrows=""yes"" data-pagination=""no"" data-lazyload=""yes"" data-loop=""no"" data-hoverpause=""yes"">

");
#nullable restore
#line 9 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"content-box\">\n                <div class=\"box-label\">\n                    <span class=\"label label-sale\">");
#nullable restore
#line 13 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
                                              Write(item.InstallmentTable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n");
#nullable restore
#line 15 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
                      
                        var imageSrcm = item.StockCode.ToLower();
                        var strImagem = imageSrcm + ".jpg";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"image-cat\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1169, "\"", 1249, 4);
            WriteAttributeValue("", 1176, "/urun/detay/", 1176, 12, true);
#nullable restore
#line 20 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue("", 1188, UrlExtension.FriendlyUrl(Url,item.StockCode), 1188, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1233, "/", 1233, 1, true);
#nullable restore
#line 20 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue("", 1234, item.StockCode, 1234, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1250, "\"", 1273, 1);
#nullable restore
#line 20 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue("", 1256, item.ProductName, 1256, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1274, "\"", 1299, 1);
#nullable restore
#line 20 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue("", 1282, item.ProductName, 1282, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 1300, "\"", 1331, 2);
            WriteAttributeValue("", 1306, "Doorema", 1306, 7, true);
#nullable restore
#line 20 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue(" ", 1313, item.ProductName, 1314, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_self\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69ab6494d72af4e4c5b6ecce99919b78360acae18457", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1387, "~/ProductImages/ProductL/", 1387, 25, true);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
AddHtmlAttributeValue("", 1412, strImagem, 1412, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
AddHtmlAttributeValue("", 1431, item.StockCode, 1431, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1534, "Doorema", 1534, 7, true);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
AddHtmlAttributeValue(" ", 1541, item.ProductName, 1542, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ref", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1566, "Doorema", 1566, 7, true);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
AddHtmlAttributeValue(" ", 1573, item.ProductName, 1574, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1598, "Dooorema", 1598, 8, true);
#nullable restore
#line 21 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
AddHtmlAttributeValue(" ", 1606, item.ProductName, 1607, 17, false);

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
            WriteLiteral("\n                        </a>\n                    </div>\n                    <div class=\"cat-title\">\n                        <a rel=\"canonical\"");
            BeginWriteAttribute("href", " href=\"", 1771, "\"", 1853, 4);
            WriteAttributeValue("", 1778, "/urun/detay/", 1778, 12, true);
#nullable restore
#line 25 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue("", 1790, UrlExtension.FriendlyUrl(Url,item.ProductName), 1790, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1837, "/", 1837, 1, true);
#nullable restore
#line 25 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue("", 1838, item.StockCode, 1838, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1854, "\"", 1887, 2);
            WriteAttributeValue("", 1862, "Doorema", 1862, 7, true);
#nullable restore
#line 25 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue(" ", 1869, item.ProductName, 1870, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 1888, "\"", 1919, 2);
            WriteAttributeValue("", 1894, "Doorema", 1894, 7, true);
#nullable restore
#line 25 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue(" ", 1901, item.ProductName, 1902, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1920, "\"", 1943, 1);
#nullable restore
#line 25 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
WriteAttributeValue("", 1926, item.ProductName, 1926, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_self\">");
#nullable restore
#line 25 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"
                                                                                                                                                                                                                                  Write(item.StockCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    </div>\n                </div>\n");
#nullable restore
#line 28 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\Discount\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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

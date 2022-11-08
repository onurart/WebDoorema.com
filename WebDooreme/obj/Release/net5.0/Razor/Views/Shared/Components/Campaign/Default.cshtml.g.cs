#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1f92a7354424b0f70754006bd273f87df00b33c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Campaign_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Campaign/Default.cshtml")]
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
#line 1 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
using WebDooreme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f92a7354424b0f70754006bd273f87df00b33c", @"/Views/Shared/Components/Campaign/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Campaign_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
      .product-card {
        width: 100%;
        position: relative;
        box-shadow: 0 2px 7px #dfdfdf;
        margin: 50px auto;
        background: #fafafa;
        

      
    }

    .badge {
        position: absolute;
        left: 0;
        top: 20px;
        text-transform: uppercase;
        font-size: 13px;
        font-weight: 700;
        background: red;
        color: #fff;
        padding: 3px 10px;
        border-radius: 0px 10px 0px 10px;
    }


    .product-tumb {
        display: flex;
        align-items: center;
        justify-content: center;
        height: 300px;
        padding: 10px;
        background: #f0f0f0;
    }

    .product-tumb img {
        max-width: 100%;
        max-height: 100%;
    }

    .product-details {
        padding: 70px;
        padding-top:2px;
    }

    .product-catagory {
        display: block;
        font-size: 1.6rem;
        font-weight: 700;
        text-transform: uppercase;
        color: #ccc;
        margin-bottom: 18px;
    }
");
            WriteLiteral(@"
    .product-details h4 a {
        font-weight: 800;
        display: block;
        margin-bottom: 18px;
        text-transform: uppercase;
        color: #ff3c20;
        text-decoration: none;
        transition: 0.3s;
        margin-left:25%;
    }

    .product-details h4 a:hover {
        color: #fbb72c;
    }

    .product-details p {
        font-size: 15px;
        line-height: 22px;
        margin-bottom: 18px;
        color: #999;
    }

    .product-bottom-details {
        overflow: hidden;
        border-top: 1px solid #ff3c20;
        padding-top: 20px;
    }

    .product-bottom-details div {
        float: left;
        width: 50%;
    }

    .product-price {
        font-size: 18px;
        color: #fbb72c;
        font-weight: 600;
    }

    .product-price small {
        font-size: 80%;
        font-weight: 400;
        text-decoration: line-through;
        display: inline-block;
        margin-right: 5px;
    }

    .product-links {
        text-align: right;
    }

    .product-links ");
            WriteLiteral("a {\n        display: inline-block;\n        margin-left: 5px;\n        color: #e1e1e1;\n        transition: 0.3s;\n        font-size: 17px;\n    }\n\n    .product-links a:hover {\n        color: #fbb72c;\n    }\n</style>\n\n\n\n\n");
#nullable restore
#line 126 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"product-card\">\n        <div class=\"badge\">");
#nullable restore
#line 130 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
                      Write(item.InstallmentTable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"product-tumb\">\n");
#nullable restore
#line 132 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
              
                var imageSrcm = item.StockCode.ToLower();
                var strImagem = imageSrcm + ".jpg";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1f92a7354424b0f70754006bd273f87df00b33c6758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2652, "~/ProductImages/ProductL/", 2652, 25, true);
#nullable restore
#line 136 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
AddHtmlAttributeValue("", 2677, strImagem, 2677, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ref", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 136 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
AddHtmlAttributeValue("", 2694, item.StockCode, 2694, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 136 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
AddHtmlAttributeValue("", 2716, item.ProductName, 2716, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 136 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
AddHtmlAttributeValue("", 2742, item.ProductName, 2742, 17, false);

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
            WriteLiteral("\n        </div>\n        <div class=\"product-details\">\n            <h4><a");
            BeginWriteAttribute("href", " href=\"", 2833, "\"", 2840, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
                      Write(item.StockCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\n            <span class=\"product-catagory\"></span>\n            <h4><a");
            BeginWriteAttribute("href", " href=\"", 2936, "\"", 2943, 0);
            EndWriteAttribute();
            WriteLiteral("></a></h4>\n            <p></p>\n            <div class=\"product-bottom-details\">\n                <div class=\"list-block\" style=\"font-size:15px; font-weight:700;display:contents; text-transform:uppercase\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 3166, "\"", 3246, 4);
            WriteAttributeValue("", 3173, "/urun/detay/", 3173, 12, true);
#nullable restore
#line 145 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
WriteAttributeValue("", 3185, UrlExtension.FriendlyUrl(Url,item.StockCode), 3185, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3230, "/", 3230, 1, true);
#nullable restore
#line 145 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
WriteAttributeValue("", 3231, item.StockCode, 3231, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_self\"");
            BeginWriteAttribute("ref", " ref=\"", 3262, "\"", 3285, 1);
#nullable restore
#line 145 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
WriteAttributeValue("", 3268, item.ProductName, 3268, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3286, "\"", 3309, 1);
#nullable restore
#line 145 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
WriteAttributeValue("", 3294, item.StockCode, 3294, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <button class=""addToCart btn-button btn btn-danger""  type=""button"" title=""Sepete Ekle"">
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
");
#nullable restore
#line 157 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\Campaign\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
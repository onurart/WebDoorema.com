#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8451c473413d0df81251b013c3b0954668fa6889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductToSubCategory), @"mvc.1.0.view", @"/Views/Product/ProductToSubCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8451c473413d0df81251b013c3b0954668fa6889", @"/Views/Product/ProductToSubCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_ProductToSubCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 2 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
      Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 80, "\"", 107, 1);
#nullable restore
#line 3 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
WriteAttributeValue("", 90, ViewBag.keywords, 90, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 141, "\"", 171, 1);
#nullable restore
#line 4 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
WriteAttributeValue("", 151, ViewBag.description, 151, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
#nullable restore
#line 6 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
  
    int? category = ViewBag.selectedCategory;
    int? subcategory = ViewBag.selectedSubCategory;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"breadcrumb\">\r\n    <li><a");
            BeginWriteAttribute("href", " href=\"", 322, "\"", 356, 1);
#nullable restore
#line 11 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
WriteAttributeValue("", 329, Url.Action("Index","Home"), 329, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-home""></i></a></li>
    <li><a href=""urun/ana-kategori/proje-celik-kapilari/8"" alt=""Kategori Ürün Listesi"" ref=""Kategori  Ürün Listesi"" title=""Kategori  Ürün Listesi"">Ürün Listesi</a></li>

</ul>

<br />
<aside class=""col-sm-4 col-md-3 content-aside"" id=""column-left"">
    ");
#nullable restore
#line 18 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
Write(await Component.InvokeAsync("ProductCategoriesMenu",new{categoryId=category,subCategoryId=subcategory}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
Write(await Component.InvokeAsync("Campaign"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</aside>\r\n<div id=\"content\" class=\"col-md-9 col-sm-8\">\r\n    <div class=\"products-category\">\r\n        ");
#nullable restore
#line 23 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Product\ProductToSubCategory.cshtml"
   Write(await Component.InvokeAsync("ProductList",new{categoryId=category,subCategoryId=subcategory}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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

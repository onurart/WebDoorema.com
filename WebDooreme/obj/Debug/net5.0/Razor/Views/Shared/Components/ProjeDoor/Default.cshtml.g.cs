#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\ProjeDoor\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e91918dee48564527ac6f2b75f3eff08f205334a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjeDoor_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjeDoor/Default.cshtml")]
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
#line 1 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\ProjeDoor\Default.cshtml"
using WebDooreme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e91918dee48564527ac6f2b75f3eff08f205334a", @"/Views/Shared/Components/ProjeDoor/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjeDoor_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""module so-extraslider-ltr extra-layout4 cus2"" style=""border-radius: 30px 30px 30px 30px"">
    <div class=""form-group col-pre"" style=""border-radius: 30px 30px 30px 30px"">
        <div class=""m-head"">
            <h1 style=""font-weight:700"" title=""Doorema Proje Kap??lar??"" ref=""Doorema Proje Kap??lar??""  alt=""Proje ??elik Kap??lar??"">Proje ??elik Kap??lar??</h1>
            <a class=""btn btn-danger"" href=""/urun/ana-kategori/proje-celik-kapilari/8"" title=""Doorema Proje Kap??lar??"" ref=""Doorema Proje Kap??lar??"">T??m??n?? G??r</a>
        </div>
    </div>
    <div class=""modcontent"">
        <div class=""so-extraslider"">
            <div class=""yt-content-slider extraslider-inner products-list"" data-rtl=""yes"" data-pagination=""no"" data-autoplay=""no"" data-delay=""4"" data-speed=""0.6"" data-margin=""20"" data-items_column0=""4"" data-items_column1=""3"" data-items_column2=""2"" data-items_column3=""2"" data-items_column4=""1"" data-arrows=""yes"" data-lazyload=""yes"" data-loop=""no"" data-buttonpage=""top"">

");
#nullable restore
#line 16 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\ProjeDoor\Default.cshtml"
                 foreach (var item in Model.Where(m => m.CategoryId == 8))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\ProjeDoor\Default.cshtml"
               Write(await Component.InvokeAsync("ProductDetail", new { stockCode = item.StockCode }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Shared\Components\ProjeDoor\Default.cshtml"
                                                                                                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

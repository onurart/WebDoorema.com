#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b4d3b5dcce3b7d60c9b1f47bd4cdcd574d8743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderCategories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderCategories/Default.cshtml")]
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
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b4d3b5dcce3b7d60c9b1f47bd4cdcd574d8743", @"/Views/Shared/Components/HeaderCategories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_HeaderCategories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDooreme.Models.MenuCategoiesViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .common-home .container-megamenu.vertical .vertical-wrapper ul.megamenu > li.with-sub-menu > a::before {
        display: none;
    }
</style>
<!-- Secondary menu -->
<div class=""bottom1 menu-vertical col-lg-2 col-md-3"">
    <!-- Secondary menu -->
    <div class=""responsive so-megamenu  megamenu-style-dev"">
        <div class=""so-vertical-menu "">
            <nav class=""navbar-default"">

                <div class=""container-megamenu vertical"">
                    <div id=""menuHeading"">
                        <div class=""megamenuToogle-wrapper"">
                            <div class=""megamenuToogle-pattern"">
                                <div class=""container"">
                                    <div>
                                        <span></span>
                                        <span></span>
                                        <span></span>
                                    </div>
                                    ??r??nler
                       ");
            WriteLiteral(@"         </div>
                            </div>
                        </div>
                    </div>
                    <div class=""navbar-header"">
                        <button type=""button"" id=""show-verticalmenu"" data-toggle=""collapse"" class=""navbar-toggle"">
                            <i class=""fa fa-bars""></i>
                            <span>??r??nler</span>
                        </button>
                    </div>
                    <div class=""vertical-wrapper"">
                        <span id=""remove-verticalmenu"" class=""fa fa-times""></span>
                        <div class=""megamenu-pattern"">
                            <div class=""container-mega"">
                                <ul class=""megamenu"">
");
#nullable restore
#line 41 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
                                     foreach (var item in Model.Categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"item-vertical with-sub-menu hover\">\r\n                                            <p class=\"close-menu\"></p>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2174, "\"", 2265, 4);
            WriteAttributeValue("", 2181, "/urun/ana-kategori/", 2181, 19, true);
#nullable restore
#line 45 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 2200, UrlExtension.FriendlyUrl(Url,item.CategoryName), 2200, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2248, "/", 2248, 1, true);
#nullable restore
#line 45 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 2249, item.CategoryId, 2249, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"clearfix\"");
            BeginWriteAttribute("title", " title=\"", 2283, "\"", 2309, 1);
#nullable restore
#line 45 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 2291, item.CategoryName, 2291, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 2310, "\"", 2334, 1);
#nullable restore
#line 45 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 2316, item.CategoryName, 2316, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2335, "\"", 2359, 1);
#nullable restore
#line 45 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 2341, item.CategoryName, 2341, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <span class=\"more-view\">");
#nullable restore
#line 46 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
                                                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                            </a>\r\n\r\n                                        </li>\r\n");
#nullable restore
#line 51 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </nav>
        </div>
    </div>
    <!-- // end Secondary menu -->
</div>
<!-- Main menu -->
<div class=""main-menu col-lg-10 col-md-9"">
    <div class=""responsive so-megamenu megamenu-style-dev"">
        <nav class=""navbar-default"">
            <div class="" container-megamenu  horizontal open "">
                <div class=""navbar-header"">
                    <button type=""button"" id=""show-megamenu"" data-toggle=""collapse"" class=""navbar-toggle"">
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                </div>

                <div class=""megamenu-wrapper"">
                    <span id=""remove-megamenu"" class=""fa fa-times""></span>
                    <div class=""megamenu-pa");
            WriteLiteral("ttern\">\r\n                        <div class=\"container-mega\">\r\n                            <ul class=\"megamenu\" data-transition=\"slide\" data-animationtime=\"250\">\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 3824, "\"", 3832, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3938, "\"", 3972, 1);
#nullable restore
#line 82 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 3945, Url.Action("Index","Home"), 3945, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""ANA SAYFA"" ref=""ANA SAYFA"" alt=""ANA SAYFA"">
                                        <strong>ANA SAYFA</strong>
                                        <span class=""label""></span>
                                    </a>
                                </li>
                                <li");
            BeginWriteAttribute("class", " class=\"", 4296, "\"", 4304, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4410, "\"", 4452, 1);
#nullable restore
#line 89 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 4417, Url.Action("Institutional","Home"), 4417, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""KURUMSAL"" ref=""KURUMSAL"" alt=""KURUMSAL"">
                                        <strong>KURUMSAL</strong>
                                        <span class=""label""></span>
                                    </a>
                                </li>
                                <li");
            BeginWriteAttribute("class", " class=\"", 4772, "\"", 4780, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4886, "\"", 4924, 1);
#nullable restore
#line 96 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 4893, Url.Action("Technical","Home"), 4893, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""TEKN??K B??LG??"" ref=""TEKN??K B??LG??"" alt=""TEKN??K B??LG??"">
                                        <strong>TEKN??K B??LG??</strong>
                                        <span class=""label""></span>
                                    </a>
                                </li>
                                <li");
            BeginWriteAttribute("class", " class=\"", 5260, "\"", 5268, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5374, "\"", 5417, 1);
#nullable restore
#line 103 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 5381, Url.Action("ProjectManeger","Home"), 5381, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""PROJE Y??NET??M??"" ref=""PROJE Y??NET??M??"" alt=""PROJE Y??NET??M??"">
                                        <strong>PROJE Y??NET??M??</strong>
                                        <span class=""label""></span>
                                    </a>
                                </li>
                                <li");
            BeginWriteAttribute("class", " class=\"", 5761, "\"", 5769, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5875, "\"", 5914, 1);
#nullable restore
#line 110 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 5882, Url.Action("References","Home"), 5882, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""REFERANSLAR"" ref=""REFERANSLAR"" alt=""REFERANSLAR"">
                                        <strong>REFERANSLAR</strong>
                                        <span class=""label""></span>
                                    </a>
                                </li>
                                <li");
            BeginWriteAttribute("class", " class=\"", 6246, "\"", 6254, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6360, "\"", 6398, 1);
#nullable restore
#line 117 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 6367, Url.Action("Documents","Home"), 6367, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""BELGELER"" ref=""BELGELER"" alt=""BELGELER"">
                                        <strong>BELGELER</strong>
                                        <span class=""label""></span>
                                    </a>
                                </li>
                                <li");
            BeginWriteAttribute("class", " class=\"", 6718, "\"", 6726, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6832, "\"", 6866, 1);
#nullable restore
#line 124 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 6839, Url.Action("Index","Blog"), 6839, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"clearfix\" title=\"Blog\" ref=\"Blog\" alt=\"Blog\">\r\n                                        <strong>Blog</strong>\r\n                                    </a>\r\n                                </li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 7101, "\"", 7109, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7215, "\"", 7247, 1);
#nullable restore
#line 130 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 7222, Url.Action("faq","Home"), 7222, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""SORU/CEVAP"" ref=""SORU/CEVAP"" alt=""SORU/CEVAP"">
                                        <strong>SORU/CEVAP</strong>
                                    </a>
                                </li>
                                <li");
            BeginWriteAttribute("class", " class=\"", 7506, "\"", 7514, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <p class=\"close-menu\"></p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7620, "\"", 7656, 1);
#nullable restore
#line 136 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\HeaderCategories\Default.cshtml"
WriteAttributeValue("", 7627, Url.Action("Contact","Home"), 7627, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""clearfix"" title=""??LET??????M"" ref=""??LET??????M"" alt=""??LET??????M"">
                                        <strong>??LET??????M</strong>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </nav>
    </div>
</div>
<!-- //end Main menu -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebDooreme.Models.MenuCategoiesViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ca73152eaa5d5abbca618891c8214754f41911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminSliders_Blog_Details), @"mvc.1.0.view", @"/Views/AdminSliders/Blog/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ca73152eaa5d5abbca618891c8214754f41911", @"/Views/AdminSliders/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminSliders_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
  
    ViewData["Title"] = "GetBlogById";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Main Container  -->\r\n<div class=\"main-container container\">\r\n    <ul class=\"breadcrumb\">\r\n        <li><a href=\"#\"><i class=\"fa fa-home\"></i></a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 277, "\"", 311, 1);
#nullable restore
#line 10 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
WriteAttributeValue("", 284, Url.Action("Index","Blog"), 284, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Blog</a></li>\r\n        <li><a href=\"#\">");
#nullable restore
#line 11 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
    </ul>
    <div class=""row"">
        <!--Left Part Start -->
        <aside class=""col-md-3 col-sm-4 col-xs-12 content-aside left_column "" id=""column-left"">
            <div class=""module blog-category titleLine"">
                <h3 class=""modtitle"">Bloglar</h3>
                ");
#nullable restore
#line 18 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
           Write(await Component.InvokeAsync("LastBlogCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </aside>\r\n        <div id=\"content\" class=\"col-md-9 col-sm-8\">\r\n            <div class=\"article-info\">\r\n                <div class=\"blog-header\">\r\n                    <h3");
            BeginWriteAttribute("class", " class=\"", 914, "\"", 922, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-weight: 800; font-size: 35px;\">");
#nullable restore
#line 24 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                                                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"article-sub-title\">\r\n                    <span class=\"article-author\"><a href=\"#\"></a></span>\r\n                    <span class=\"article-date\">");
#nullable restore
#line 28 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                                          Write(Model.CreateDate?.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 28 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                                                                 Write(Model.CreateDate?.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 28 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                                                                                          Write(Model.CreateDate?.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 28 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                                                                                                                    Write(Model.CreateDate?.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 28 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                                                                                                                                            Write(Model.CreateDate?.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1400, "\"", 1430, 2);
            WriteAttributeValue("", 1407, "/upload/", 1407, 8, true);
#nullable restore
#line 31 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
WriteAttributeValue("", 1415, Model.ImageUrl, 1415, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-popup\"><img");
            BeginWriteAttribute("src", " src=\"", 1456, "\"", 1485, 2);
            WriteAttributeValue("", 1462, "/upload/", 1462, 8, true);
#nullable restore
#line 31 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
WriteAttributeValue("", 1470, Model.ImageUrl, 1470, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Kire tuma demonstraverunt lector\"></a>\r\n                </div>\r\n                <div style=\"font-weight:600; font-size: 16px; margin: 0; line-height: 32px;\" class=\"article-description\">\r\n                    <p>");
#nullable restore
#line 34 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Details.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "890b48773903471efe3728422e76cae7e831c4cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Documents), @"mvc.1.0.view", @"/Views/Home/Documents.cshtml")]
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
#line 1 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
using WebDooreme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"890b48773903471efe3728422e76cae7e831c4cb", @"/Views/Home/Documents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Documents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Document>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 4 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
      Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
                WriteLiteral("    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 194, "\"", 224, 1);
#nullable restore
#line 6 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
WriteAttributeValue("", 204, ViewBag.description, 204, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral("<div class=\"main-container container\">\r\n    <ul class=\"breadcrumb\">\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 316, "\"", 350, 1);
#nullable restore
#line 10 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
WriteAttributeValue("", 323, Url.Action("Index","Home"), 323, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-home""></i> Ana Sayfa</a></li>
        <li><a href=""#"">Belgeler</a></li>
    </ul>
    <div class=""row"">
        <!--Left Part Start -->
        <!--Left Part End -->
        <!--Middle Part Start-->
        <div id=""content"" class=""col-lg-offset-1 col-md-10 col-sm-8"" style=""margin-right:-50px"">
            <div class=""blog-header"">
            </div>
            <div class=""blog-category clearfix"">
                <div class=""blog-listitem row"">
");
#nullable restore
#line 22 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""blog-item col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                            <div class=""blog-item-inner clearfix"">
                                <div class=""itemBlogImg clearfix"">
                                    <div class=""article-image"">
                                        <div>
                                            <a class=""popup-gallery""");
            BeginWriteAttribute("href", " href=\"", 1305, "\"", 1325, 1);
#nullable restore
#line 29 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
WriteAttributeValue("", 1312, item.Aimages, 1312, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 1381, "\"", 1399, 1);
#nullable restore
#line 30 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
WriteAttributeValue("", 1387, item.Images, 1387, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1400, "\"", 1416, 1);
#nullable restore
#line 30 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
WriteAttributeValue("", 1406, item.Name, 1406, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""itemBlogContent clearfix"">
                                    <div class=""blog-content"">
                                        <div class=""article-title font-title"">
                                            <h4>
                                                <a class=""popup-gallery""");
            BeginWriteAttribute("href", " href=\"", 1942, "\"", 1962, 1);
#nullable restore
#line 39 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
WriteAttributeValue("", 1949, item.Aimages, 1949, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                            </h4>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 46 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\Documents.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Document>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34590db9590cac0aa78dc0c29ed16b3781d12d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Technical), @"mvc.1.0.view", @"/Views/Home/Technical.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34590db9590cac0aa78dc0c29ed16b3781d12d7", @"/Views/Home/Technical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Technical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Technical>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/w3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 3 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
      Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 104, "\"", 131, 1);
#nullable restore
#line 4 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 114, ViewBag.keywords, 114, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 165, "\"", 195, 1);
#nullable restore
#line 5 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 175, ViewBag.description, 175, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b34590db9590cac0aa78dc0c29ed16b3781d12d75017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
     foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"breadcrumb\">\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 335, "\"", 369, 1);
#nullable restore
#line 11 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 342, Url.Action("Index","Home"), 342, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-home""></i> Ana Sayfa</a></li>
        <li><a href=""#"">Teknik Bilgi</a></li>
    </ul>
    <div class=""w3-container w3-content w3-center w3-padding-64"" style=""max-width:1300px"" id=""band"">
        <h2 class=""w3-wide about-textt"" style=""line-height:25px; font-weight:bold; text-transform:uppercase;color: #ed1c24;""");
            BeginWriteAttribute("title", " title=\"", 702, "\"", 721, 1);
#nullable restore
#line 15 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 710, item.T??tle, 710, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 722, "\"", 739, 1);
#nullable restore
#line 15 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 728, item.T??tle, 728, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 740, "\"", 757, 1);
#nullable restore
#line 15 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 746, item.T??tle, 746, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
                                                                                                                                                                                Write(item.T??tle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"w3-justify about-textt\" style=\"font-size:15px;line-height:25px;text-align:justify; color:black\">\r\n            ");
#nullable restore
#line 17 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
       Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <h2 class=\"w3-wide about-textt\"");
            BeginWriteAttribute("title", " title=\"", 974, "\"", 994, 1);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 982, item.Title2, 982, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 995, "\"", 1013, 1);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 1001, item.Title2, 1001, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1014, "\"", 1032, 1);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 1020, item.Title2, 1020, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> style=\"color: #ed1c24; font-weight:bold;text-transform:uppercase\">");
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
                                                                                                                                                                 Write(item.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"w3-justify about-textt\" style=\"font-size:15px;line-height:25px;text-align:justify; color:black\">\r\n            ");
#nullable restore
#line 21 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
       Write(item.Ac??klama2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
        <div class=""row"">
            <div id=""content"" class=""col-md-12 col-sm-3"">
                <div class=""blog-header"">
                </div> <div id=""content"" class=""col-md-12 col-sm-8"">
                    <div class=""blog-category clearfix"">
                        <div class=""blog-category clearfix"">
                            <div class=""blog-listitem row"" style=""display:flex"">
                                <div class=""blog-item col-lg-4 col-md-12 col-sm-8 col-xs-12"">
                                    <div class=""blog-item-inner clearfix"">
                                        <div class=""itemBlogImg clearfix"">
                                            <div class=""article-image"">
                                                <div>
                                                    <a class=""popup-gallery""");
            BeginWriteAttribute("href", " href=\"", 2131, "\"", 2151, 1);
#nullable restore
#line 35 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 2138, item.A??mages, 2138, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 2215, "\"", 2233, 1);
#nullable restore
#line 36 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 2221, item.??mages, 2221, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2234, "\"", 2252, 1);
#nullable restore
#line 36 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 2240, item.Title2, 2240, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""blog-item col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""blog-item-inner clearfix"">
                                        <div class=""itemBlogImg clearfix"">
                                            <div class=""article-image"">
                                                <div>
                                                    <a class=""popup-gallery""");
            BeginWriteAttribute("href", " href=\"", 3006, "\"", 3027, 1);
#nullable restore
#line 48 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 3013, item.Aimages2, 3013, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 3091, "\"", 3110, 1);
#nullable restore
#line 49 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 3097, item.Images2, 3097, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3111, "\"", 3128, 1);
#nullable restore
#line 49 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 3117, item.T??tle, 3117, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""blog-item col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""blog-item-inner clearfix"">
                                        <div class=""itemBlogImg clearfix"">
                                            <div class=""article-image"">
                                                <div>
                                                    <a class=""popup-gallery""");
            BeginWriteAttribute("href", " href=\"", 3882, "\"", 3903, 1);
#nullable restore
#line 61 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 3889, item.Aimages3, 3889, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 3967, "\"", 3986, 1);
#nullable restore
#line 62 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 3973, item.Images3, 3973, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3987, "\"", 4005, 1);
#nullable restore
#line 62 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 3993, item.Title2, 3993, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                    </a>
                                                </div>
                                                <div class=""article-date"">
                                                    <div class=""date"">
                                                        <span class=""article-date"">
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""blog-item col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""blog-item-inner clearfix"">
                                        <div class=""itemBlogImg clearfix"">
                                            <div class=""artic");
            WriteLiteral("le-image\">\r\n                                                <div>\r\n                                                    <a class=\"popup-gallery\"");
            BeginWriteAttribute("href", " href=\"", 5173, "\"", 5194, 1);
#nullable restore
#line 80 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 5180, item.Aimages2, 5180, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 5258, "\"", 5277, 1);
#nullable restore
#line 81 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 5264, item.Images4, 5264, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5278, "\"", 5296, 1);
#nullable restore
#line 81 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
WriteAttributeValue("", 5284, item.Title2, 5284, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                    </a>
                                                </div>
                                                <div class=""article-date"">
                                                    <div class=""date"">
                                                        <span class=""article-date"">
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 101 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Technical.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Technical>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

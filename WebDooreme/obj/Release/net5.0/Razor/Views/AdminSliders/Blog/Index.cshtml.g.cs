#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f27cdacaf0901860e1cd42687756f260500b5e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminSliders_Blog_Index), @"mvc.1.0.view", @"/Views/AdminSliders/Blog/Index.cshtml")]
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
#line 1 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
using WebDooreme.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f27cdacaf0901860e1cd42687756f260500b5e9a", @"/Views/AdminSliders/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminSliders_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("res layout-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27cdacaf0901860e1cd42687756f260500b5e9a4235", async() => {
                WriteLiteral("\r\n    <div id=\"wrapper\" class=\"wrapper-fluid banners-effect-5\">\r\n        <div class=\"main-container container\">\r\n            <ul class=\"breadcrumb\">\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 343, "\"", 377, 1);
#nullable restore
#line 11 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 350, Url.Action("Index","Home"), 350, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-home""> Ana Sayfa</i></a></li>
                <li><a href=""#"">Blog</a></li>
            </ul>
            <div class=""row"">
                <!--Left Part Start -->
                <aside class=""col-md-3 col-sm-4 col-xs-12 content-aside left_column "" id=""column-left"">
                    <div class=""module blog-category titleLine"" style=""background:#ffffff"">
                        <h3 class=""modtitle"">En Son Blog Yazilari</h3>
                        ");
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
                   Write(await Component.InvokeAsync("LastBlogCategories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </aside>\r\n                <div id=\"content\" class=\"col-md-9 col-sm-8\">\r\n                    <div class=\"blog-category clearfix\">\r\n                        <div class=\"blog-listitem row\">\r\n");
#nullable restore
#line 25 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""blog-item col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""blog-item-inner clearfix"">
                                        <div class=""itemBlogImg clearfix"">
                                            <div class=""article-image"">
                                                <div>
                                                    <a class=""popup-gallery""");
                BeginWriteAttribute("href", " href=\"", 1680, "\"", 1709, 2);
                WriteAttributeValue("", 1687, "/upload/", 1687, 8, true);
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 1695, item.ImageUrl, 1695, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        <img");
                BeginWriteAttribute("src", " src=\"", 1773, "\"", 1801, 2);
                WriteAttributeValue("", 1779, "/upload/", 1779, 8, true);
#nullable restore
#line 33 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 1787, item.ImageUrl, 1787, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1802, "\"", 1819, 1);
#nullable restore
#line 33 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 1808, item.Title, 1808, 11, false);

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
                                                            <b>");
#nullable restore
#line 39 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
                                                          Write(item.CreateDate?.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 39 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
                                                                                Write(item.CreateDate?.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""itemBlogContent clearfix "">
                                            <div class=""blog-content"">
                                                <div class=""article-title font-title"">
                                                    <h4><a");
                BeginWriteAttribute("href", " href=\"", 2866, "\"", 2935, 4);
                WriteAttributeValue("", 2873, "/blog/detay/", 2873, 12, true);
#nullable restore
#line 48 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 2885, UrlExtension.FriendlyUrl(Url,item.Title), 2885, 41, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2926, "/", 2926, 1, true);
#nullable restore
#line 48 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 2927, item.Id, 2927, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
                                                                                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h4>\r\n                                                </div>\r\n                                                <div class=\"blog-meta\">\r\n");
                WriteLiteral("                                                </div>\r\n                                                <p class=\"article-description\" style=\"font-weight:600\">");
#nullable restore
#line 53 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
                                                                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                <div class=\"readmore\">\r\n                                                    <a class=\"btn-readmore font-title\"");
                BeginWriteAttribute("href", " href=\"", 3566, "\"", 3635, 4);
                WriteAttributeValue("", 3573, "/blog/detay/", 3573, 12, true);
#nullable restore
#line 55 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 3585, UrlExtension.FriendlyUrl(Url,item.Title), 3585, 41, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3626, "/", 3626, 1, true);
#nullable restore
#line 55 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
WriteAttributeValue("", 3627, item.Id, 3627, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-caret-right""></i>Devamı...</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 61 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminSliders\Blog\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div class=""product-filter product-filter-bottom filters-panel clearfix"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

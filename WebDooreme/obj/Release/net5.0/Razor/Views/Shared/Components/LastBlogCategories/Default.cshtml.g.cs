#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d073d23506bc1746b9e610f4b508d37c89d3056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LastBlogCategories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LastBlogCategories/Default.cshtml")]
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
#line 12 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
using WebDooreme.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d073d23506bc1746b9e610f4b508d37c89d3056", @"/Views/Shared/Components/LastBlogCategories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_LastBlogCategories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modcontent\">\r\n    <ul class=\"list-group \">\r\n        <li class=\"list-group-item\"> <a href=\"blog-page.html\" class=\"group-item active\"></a></li>\r\n");
#nullable restore
#line 16 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 716, "\"", 785, 4);
            WriteAttributeValue("", 723, "/blog/detay/", 723, 12, true);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
WriteAttributeValue("", 735, UrlExtension.FriendlyUrl(Url,item.Title), 735, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 776, "/", 776, 1, true);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
WriteAttributeValue("", 777, item.Id, 777, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"group-item\"");
            BeginWriteAttribute("title", " title=\"", 805, "\"", 824, 1);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
WriteAttributeValue("", 813, item.Title, 813, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("ref", " ref=\"", 825, "\"", 842, 1);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
WriteAttributeValue("", 831, item.Title, 831, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 843, "\"", 860, 1);
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
WriteAttributeValue("", 849, item.Title, 849, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
                                                                                                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 21 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\LastBlogCategories\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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

#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\ReferansTables\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5af25e58a2eb9304299ecdfedcb007d79636661f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ReferansTables_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ReferansTables/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af25e58a2eb9304299ecdfedcb007d79636661f", @"/Views/Shared/Components/ReferansTables/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ReferansTables_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReferansTable>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 34, "\"", 42, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:85%;"">

    <br />
    <table class=""table table-striped"" style=""margin-left:10%"">
        <thead>
            <tr>
                <th>
                    Firma Adı
                </th>
                <th>
                    İlçe
                </th>
                <th>
                    İl
                </th>
            </tr>
        </thead>
        <tbody style=""font-weight:700"">
");
#nullable restore
#line 21 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\ReferansTables\Default.cshtml"
             foreach (var item in Model)
            
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                       ");
#nullable restore
#line 26 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\ReferansTables\Default.cshtml"
                  Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                       ");
#nullable restore
#line 29 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\ReferansTables\Default.cshtml"
                  Write(item.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                       ");
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\ReferansTables\Default.cshtml"
                  Write(item.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Shared\Components\ReferansTables\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReferansTable>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e1d7602c7853298cbf0e7f49ab8b32853df7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e1d7602c7853298cbf0e7f49ab8b32853df7e2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
      Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
                WriteLiteral("    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 145, "\"", 175, 1);
#nullable restore
#line 4 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
WriteAttributeValue("", 155, ViewBag.description, 155, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral("  \r\n    ");
#nullable restore
#line 7 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row box-content2\">\r\n        ");
#nullable restore
#line 9 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("tse"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"row box-content2\">\r\n            ");
#nullable restore
#line 11 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Discount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("WheyDooreme"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 16 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("ProjeDoor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("SteelDoor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("VillaDoor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("FireDoor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 20 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Blog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Referans"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\ProjectManeger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11b75a619dc08f4a950961f1626bbc48b749e259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProjectManeger), @"mvc.1.0.view", @"/Views/Home/ProjectManeger.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11b75a619dc08f4a950961f1626bbc48b749e259", @"/Views/Home/ProjectManeger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProjectManeger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/ProjectManager/projekapak.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Doorema Çelik Kapı"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/ProjectManager/PROJEDİA.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("700"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Client"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\ProjectManeger.cshtml"
      Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 80, "\"", 107, 1);
#nullable restore
#line 3 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\ProjectManeger.cshtml"
WriteAttributeValue("", 90, ViewBag.keywords, 90, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 141, "\"", 171, 1);
#nullable restore
#line 4 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\ProjectManeger.cshtml"
WriteAttributeValue("", 151, ViewBag.description, 151, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral(@"<style>
    .projectManager {
        width: 100%;
        display: flex;
        justify-content: space-between;
        background-color: red
    }
    .projectLeft {
        width: 300px;
        background-color: yellow
    }
    .projectCenter {
        width: 300px;
        background-color: yellow;
    }
    .projectRigh {
        width: 700px;
        float: right;
        background-color: yellow
    }
    .projecManagerImages {
        text-align: center;
        margin: 10px;
        margin: 10px;
    }
  
</style>
<div class=""main-container container"">
    <ul class=""breadcrumb"">
        <li><a");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 856, 1);
#nullable restore
#line 35 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\ProjectManeger.cshtml"
WriteAttributeValue("", 829, Url.Action("Index","Home"), 829, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-home""></i> Ana Sayfa</a></li>
        <li><a href=""#"">Proje Yönetimi</a></li>
    </ul>
    <div class=""about-us about-demo-3"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-6 projecManagerImages"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11b75a619dc08f4a950961f1626bbc48b749e2597519", async() => {
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6 about-image\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11b75a619dc08f4a950961f1626bbc48b749e2598712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </div>
            <div class=""col-lg-6 col-md-6 about-info"">
                <h1 style=""color: #ed1c24; font-weight:bold;text-transform:uppercase"">PROJE YÖNETİMİ</h1>
                <div class=""about-text about-textt"">
                    <p style=""font-size:14px;line-height:25px;text-align:justify; color:black""><b >Doorema Çelik Kapı</b>, uzun yılların katmış olduğu tecrübe ile projelerde yüksek kalitede hizmet sunmaktadır. Firmamız çalışmalarını alanında uzman çalışanları ile yenilikçi ve çözüm odaklı bir şekilde sürdürmektedir. Projelerin ihtiyaçları doğrultusunda, gerekli olan inceleme ve analizlerle proje yönetim adımları da gözetilerek ürün ve hizmet sağlanmaktadır. Projelerin şartnamelerinin gerektirdiği tüm özellikleri karşılayarak çalışmalarını yürüten Doorema Çelik Kapı; kaliteli malzeme, doğru fiyat, planlanan süre içerisinde teslimat ve montaj, montajdan sonra oluşabilecek olan sorunlarla ilgili teknik destek gibi hizmetleri sağlayarak proje bazlı çalışmalarını istek ve beklentileri karşıla");
            WriteLiteral(@"yarak sunmaktadır.</p>
                        <p style=""font-size:14px;line-height:25px;text-align:justify;color:black"">
                        <b>Doorema Çelik Kapı</b> olarak, kalitemizi her zaman üst seviyede tutarak, her gün değişen ve gelişen teknolojiyi de yakından takip ederek, üretim ve hizmetlerimize devam etmekteyiz.
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 56 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\Home\ProjectManeger.cshtml"
Write(await Component.InvokeAsync("Referans"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
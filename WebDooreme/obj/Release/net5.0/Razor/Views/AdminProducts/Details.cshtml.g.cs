#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af0dc5d2afbe7edc09d75cfbb27ed9330e2ebed8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProducts_Details), @"mvc.1.0.view", @"/Views/AdminProducts/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0dc5d2afbe7edc09d75cfbb27ed9330e2ebed8", @"/Views/AdminProducts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminProducts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDooreme.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StockCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.StockCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StockUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.StockUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Keywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Keywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallmentTable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.InstallmentTable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 78 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountPrice2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountPrice2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 84 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountPrice3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 87 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountPrice3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 90 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RelegatePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 93 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.RelegatePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 96 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CargoPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 99 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CargoPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 102 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 105 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 108 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CargoDiamension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 111 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CargoDiamension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 114 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 117 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 120 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 123 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImageDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 126 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 129 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 132 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 135 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 138 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 141 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 144 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 147 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 150 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 153 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 156 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 159 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 162 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Campaign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 165 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Campaign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 168 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 171 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 174 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PopulateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 177 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.PopulateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 180 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 183 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 186 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 189 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpecialProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 192 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MainPageProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 195 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.MainPageProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 198 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecomandedProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 201 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecomandedProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 204 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ViewCase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 207 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ViewCase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 210 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 213 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 216 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubCategoryClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 219 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubCategoryClass.SubCategoryClassId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af0dc5d2afbe7edc09d75cfbb27ed9330e2ebed826765", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 224 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\AdminProducts\Details.cshtml"
                           WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af0dc5d2afbe7edc09d75cfbb27ed9330e2ebed828916", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebDooreme.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296265316bf43291fe24800ec458c406a8bf010f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ozel_Delete), @"mvc.1.0.view", @"/Views/ozel/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296265316bf43291fe24800ec458c406a8bf010f", @"/Views/ozel/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ozel_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDooreme.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n<h1>Delete</h1>\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StockCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StockCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StockUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StockUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Keywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Keywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallmentTable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InstallmentTable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountPrice2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiscountPrice2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountPrice3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiscountPrice3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RelegatePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RelegatePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CargoPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CargoPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CargoDiamension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CargoDiamension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImageDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Campaign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Campaign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NewProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NewProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PopulateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PopulateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiscountProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpecialProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MainPageProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MainPageProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RecomandedProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RecomandedProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ViewCase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ViewCase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 218 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubCategoryClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 221 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubCategoryClass.SubCategoryClassId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296265316bf43291fe24800ec458c406a8bf010f27724", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "296265316bf43291fe24800ec458c406a8bf010f27991", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 225 "C:\Users\Rasim\source\OnurProJeleri\WebDooreme\WebDooreme\Views\ozel\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296265316bf43291fe24800ec458c406a8bf010f29789", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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

#pragma checksum "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a90111ef546c37518b2091d41ecd6f138c7a717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ozel_Index), @"mvc.1.0.view", @"/Views/ozel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a90111ef546c37518b2091d41ecd6f138c7a717", @"/Views/ozel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c688d4468e27e1b886d881d1fd039e4d586ea4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ozel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebDooreme.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Index</h1>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a90111ef546c37518b2091d41ecd6f138c7a7174578", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StockCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StockUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Keywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InstallmentTable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountPrice2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountPrice3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RelegatePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CargoPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CargoDiamension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Thumbnail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Thumbnail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Thumbnail3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 83 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 86 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 89 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Campaign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NewProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PopulateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 98 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 101 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpecialProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 104 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MainPageProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 107 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RecomandedProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 110 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ViewCase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 113 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 116 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubCategoryClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 122 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 126 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SubCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 129 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 132 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StockCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 135 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StockUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 138 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 141 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 144 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Keywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 147 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 150 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.InstallmentTable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 153 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 156 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 159 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiscountPrice2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 162 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiscountPrice3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 165 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RelegatePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 168 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CargoPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 171 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 174 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CargoDiamension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 177 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 180 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ImageDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 183 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Thumbnail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 186 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Thumbnail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 189 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Thumbnail3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 192 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 195 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 198 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 201 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Campaign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 204 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NewProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 207 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PopulateProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 210 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiscountProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 213 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SpecialProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 216 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MainPageProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 219 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RecomandedProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 222 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ViewCase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 225 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 228 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SubCategoryClass.SubCategoryClassId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a90111ef546c37518b2091d41ecd6f138c7a71728463", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 231 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
                                           WriteLiteral(item.ProductId);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a90111ef546c37518b2091d41ecd6f138c7a71730634", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 232 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
                                              WriteLiteral(item.ProductId);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a90111ef546c37518b2091d41ecd6f138c7a71732811", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 233 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
                                             WriteLiteral(item.ProductId);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 236 "C:\Users\saran\Desktop\WebDooreme\WebDooreme\Views\ozel\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebDooreme.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4919200eff82a7ae16134392dc24df6b2f4871bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductOnSale_Index), @"mvc.1.0.view", @"/Views/ProductOnSale/Index.cshtml")]
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
#line 1 "D:\FinalFix\AWork.Web\Views\_ViewImports.cshtml"
using AWork.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalFix\AWork.Web\Views\_ViewImports.cshtml"
using AWork.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4919200eff82a7ae16134392dc24df6b2f4871bb", @"/Views/ProductOnSale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1683cd99f6100561ab4f2b698f40be1084e5b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductOnSale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<AWork.Contracts.Dto.Production.ProductDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4919200eff82a7ae16134392dc24df6b2f4871bb4789", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product On Sale</h1>\r\n\r\n");
#nullable restore
#line 11 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
 using (Html.BeginForm("Index", "ProductOnSale", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"input-group mb-1\">\r\n        ");
#nullable restore
#line 14 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
   Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string, new{@class="form-control", @placeholder="Loking For?"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button class=\"btn btn-outline-secondary\" type=\"submit\" id=\"button-addon2\">Search</button>\r\n    </div>\r\n");
#nullable restore
#line 17 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6 col-lg-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4919200eff82a7ae16134392dc24df6b2f4871bb7357", async() => {
                WriteLiteral("\r\n            <div class=\"card mb-4\">\r\n                <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 810, "\"", 932, 1);
#nullable restore
#line 24 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
WriteAttributeValue("", 816, Url.Content("~/Resources/images/" + item.ProductProductPhotos.FirstOrDefault().ProductPhoto.ThumbnailPhotoFileName), 816, 116, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n                    <p class=\"card-text\">\r\n                        <center><b>");
#nullable restore
#line 27 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.ProductModel));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></center>\r\n                    </p>\r\n                    <p class=\"card-text\">\r\n                        ");
#nullable restore
#line 30 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                   Write(Html.LabelFor(modelItem => item.ProductId, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 31 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 33 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                   Write(Html.LabelFor(modelItem => item.SafetyStockLevel, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 34 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SafetyStockLevel));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 36 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                   Write(Html.LabelFor(modelItem => item.ListPrice, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 37 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ListPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        <br> <br>\r\n");
                WriteLiteral("                    </p>\r\n                </div>\r\n            </div>\r\n        ");
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
#line 22 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 50 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    Page Size : ");
#nullable restore
#line 54 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
           Write(Html.DropDownList("PageSize",
    ViewBag.PageSize as SelectList,
    new{
    @placeholder="Page Size",
    @onchange="getPagedSize(this.value)"
    }
    ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 62 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new{page, PageSize = ViewBag.psize, currentFilter = ViewBag.CurrentFilter, sortOrder = ViewBag.CurrentSort})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script>\r\n    function getPagedSize(value) {\r\n        document.location.href = \"/ProductOnSale?&PageSize=\" + value + \"&currentFilter=");
#nullable restore
#line 66 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                                                                                  Write(ViewBag.CurrentFilter);

#line default
#line hidden
#nullable disable
            WriteLiteral("&sortOrder=");
#nullable restore
#line 66 "D:\FinalFix\AWork.Web\Views\ProductOnSale\Index.cshtml"
                                                                                                                   Write(ViewBag.CurrentSort);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<AWork.Contracts.Dto.Production.ProductDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

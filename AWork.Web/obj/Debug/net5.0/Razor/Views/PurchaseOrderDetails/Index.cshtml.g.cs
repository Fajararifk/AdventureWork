#pragma checksum "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "057a2925944b7bf71de8127119a7e91013857595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrderDetails_Index), @"mvc.1.0.view", @"/Views/PurchaseOrderDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057a2925944b7bf71de8127119a7e91013857595", @"/Views/PurchaseOrderDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1683cd99f6100561ab4f2b698f40be1084e5b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PurchaseOrderDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AWork.Contracts.Dto.Purchasing.PurchaseOrderDetailsDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Cart Purchase Items Vendors</h1>\r\n\r\n");
#nullable restore
#line 74 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6 col-lg-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057a2925944b7bf71de8127119a7e910138575953962", async() => {
                WriteLiteral("\r\n            <div class=\"card mb-4\">\r\n");
                WriteLiteral("                <div class=\"card-body\">\r\n                    <p class=\"card-text\">\r\n                     \r\n                        <center><b>");
#nullable restore
#line 83 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></center>\r\n                    </p>\r\n                    <p class=\"card-text\">\r\n                        ");
#nullable restore
#line 86 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.PurchaseOrderId, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 87 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.PurchaseOrderId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 89 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.OrderDate, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 90 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 92 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.Vendor.AccountNumber, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 93 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.Vendor.AccountNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 95 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.Vendor.Name, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 96 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.Vendor.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 98 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.Product.Name, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 99 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.Product.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 101 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.OrderQty, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 102 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.OrderQty));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 104 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.UnitPrice, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 105 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.UnitPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 107 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.LineTotal, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 108 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.LineTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 110 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.ShipMethod.Name, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 111 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.ShipMethod.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 113 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.ShipMethodId, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 114 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.ShipMethodId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 116 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.ShipMethod.ShipRate, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 117 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.ShipMethod.ShipRate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 119 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.ShipMethod.ShipBase, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 120 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.ShipMethod.ShipBase));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 122 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.LabelFor(modelItem=>item.PurchaseOrder.ShipDate, htmlAttributes : new{@class="form-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" :\r\n                        ");
#nullable restore
#line 123 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.PurchaseOrder.ShipDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        <td>\r\n                            ");
#nullable restore
#line 126 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                       Write(Html.ActionLink("Create", "Create", new { /* id=item.PrimaryKey */ id = item.PurchaseOrderDetailId}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 127 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ id = item.PurchaseOrderDetailId}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 128 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                       Write(Html.ActionLink("EditPurchase", "EditPurchase", new { /* id=item.PrimaryKey */ id = item.PurchaseOrderDetailId}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 129 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ id = item.PurchaseOrderDetailId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 130 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ id = item.PurchaseOrderDetailId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        ");
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
#line 77 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
                                  WriteLiteral(item.PurchaseOrderId);

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
#line 138 "D:\FinalFix\AWork.Web\Views\PurchaseOrderDetails\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AWork.Contracts.Dto.Purchasing.PurchaseOrderDetailsDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef900a7a550d31f742009ce937c1b0bd6231cc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomersRepo_Details), @"mvc.1.0.view", @"/Views/CustomersRepo/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef900a7a550d31f742009ce937c1b0bd6231cc4", @"/Views/CustomersRepo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1683cd99f6100561ab4f2b698f40be1084e5b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CustomersRepo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AWork.Contracts.Dto.Sales.SalesCustomer.CustomerDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"text-center mb-3\">Customer Details</h3>\r\n    </div>\r\n    <div class=\"card-body row g-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cef900a7a550d31f742009ce937c1b0bd6231cc45798", async() => {
                WriteLiteral(@"
            <div class=""col-md-11"">
                <div class=""col-md-11"">
                    <label for=""inputPassword4"" class=""form-label"">Account Number</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 17 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(model => model.AccountNumber,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral(@"            </div>
            <div class=""row g-3"">
                <div class=""col-md-4"">
                    <label for=""inputPassword4"" class=""form-label"">Full Name</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 33 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Person.FirstName,Model.Person.FirstName +" "+ Model.Person.MiddleName+" "+Model.Person.LastName,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-2"">
                    <label for=""inputPassword4"" class=""form-label"">MiddleName</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 40 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Person.MiddleName,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-3"">
                    <label for=""inputPassword4"" class=""form-label"">LastName</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 47 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Person.LastName,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-1"">
                    <label for=""inputPassword4"" class=""form-label"">Title</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 54 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Person.Suffix,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""row g-3"">
                <div class=""col-md-4"">
                    <label for=""inputAddress2"" class=""form-label"">Name</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 63 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Territory.Name,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-3"">
                    <label for=""inputAddress2"" class=""form-label"">Country Code</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 70 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Territory.CountryRegionCode,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-3"">
                    <label for=""inputZip"" class=""form-label"">Group</label>
                    <div class=""input-group input-group-merge"">
                        ");
#nullable restore
#line 77 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Territory.Group,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""row g-3"">
                <div class=""col-md-5"">
                    <label for=""inputPassword4"" class=""form-label"">Store Name</label>
                    <div>
                        ");
#nullable restore
#line 86 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Store.Name,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-5\">\r\n                    <label for=\"inputPassword4\" class=\"form-label\">Store ID</label>\r\n                    <div>\r\n                        ");
#nullable restore
#line 93 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                   Write(Html.TextBoxFor(Model => Model.StoreId,
                        new{@class="form-control", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <div class=\"row g-3\">\r\n                <div class=\"col-md-2\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cef900a7a550d31f742009ce937c1b0bd6231cc412473", async() => {
                    WriteLiteral("\r\n                        Edit Data\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "D:\FinalFix\AWork.Web\Views\CustomersRepo\Details.cshtml"
                                                WriteLiteral(Model.CustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cef900a7a550d31f742009ce937c1b0bd6231cc414984", async() => {
                    WriteLiteral("\r\n                        Back\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AWork.Contracts.Dto.Sales.SalesCustomer.CustomerDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "229525faf61efbe095e43a51e49b343baaa93949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonCreditCards_Index), @"mvc.1.0.view", @"/Views/PersonCreditCards/Index.cshtml")]
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
#line 2 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229525faf61efbe095e43a51e49b343baaa93949", @"/Views/PersonCreditCards/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1683cd99f6100561ab4f2b698f40be1084e5b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PersonCreditCards_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<AWork.Contracts.Dto.Sales.PersonCreditCard.PersonCreditCardDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "229525faf61efbe095e43a51e49b343baaa939494365", async() => {
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
#line 4 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1><box-icon name='id-card'>Person CreditCard</box-icon>
<img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADwAAAA8CAYAAAA6/NlyAAAAAXNSR0IArs4c6QAAAkBJREFUaEPtmr0uBUEUx3/eQKGWeAI8gKDRUlGiEh2NFg1RaXU+Kho8Al4ACT29Rk1CjuwNd3dmd/aandmPcxJR3Pk4v/M/O3t2ZobomA11jBcFbrviqrAq3LIIaEq3TNAMjiqcCskysALMNET5G+AEOLX5m6fwcQLbENY+NwV61eS4DVhUFeAmmwALeJ/ZgO+BiSbTAg/ApCvwV8Nhe+5nBLUpbAKu+4ru5LMCJ7ngFK2apb2Tz6qwKvybt2UWrSlgHZgFRoBn4BLYAz4rehSipfQacGSBkvf7HPBWAXQU4FHgtQDmDJAa3WQ7gEsNsGvoHAV4CzhwUG8YeHd02rUkjgJ8Diw5AE8Dd20AvgAWuwTcuZT2sWg5JAiyuKUtyjMsTnTqtdSLerrweAKugH3gw0XCAdpEU3gAX710UWDIHhb6/lqSgkKqqAXDTucLILuKsqMo//NMdknlXW2zWlRaG8A2INBFJsCbyb6TrcSUsWxmEipYSgvg4YBbusadRfh57dQW+BqYL5I053f5hEyneG2Bfexfy7M9lgpIbYFFmbzFxVX4dGrLopV3vBOt0nL5dnWBllXXBOHSt9cmyKLVOeAyClTdNojCVUOUGV+BQ5SWZRTx3VYV/q/CvhUJMZ7zcakcJo+H8KjCOR5Nh/p65eFPxOV+hO2EoEJhvAwt39xS52es6IBMOsmfj3rZC0nBILfJRZbMZZZevyLgEE4GnUOBg4Y7wmSqcISgB51SFQ4a7giTqcIRgh50ys4p/A3XzIo9qaOhdQAAAABJRU5ErkJggg==""/></h1>
");
#nullable restore
#line 10 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
 using (Html.BeginForm("Index", "PersonCreditCards", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"input-group mb-1\">\r\n        ");
#nullable restore
#line 13 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
   Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string, new{@class="form-control", @placeholder="CreditCardId"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button class=\"btn btn-outline-secondary\" type=\"submit\" id=\"button-addon2\">Search</button>\r\n    </div>\r\n");
#nullable restore
#line 16 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 30 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().BusinessEntity.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().CreditCard.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().CreditCard.ExpMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().CreditCard.ExpYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 48 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 55 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BusinessEntity.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreditCard.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreditCard.ExpMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreditCard.ExpYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 81 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    Page Size : ");
#nullable restore
#line 85 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
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
#line 93 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new{page, PageSize = ViewBag.psize, currentFilter = ViewBag.CurrentFilter, sortOrder = ViewBag.CurrentSort})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script>\r\n    function getPagedSize(value) {\r\n        document.location.href = \"/PersonCreditCards?&PageSize=\" + value + \"&currentFilter=");
#nullable restore
#line 97 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
                                                                                      Write(ViewBag.CurrentFilter);

#line default
#line hidden
#nullable disable
            WriteLiteral("&sortOrder=");
#nullable restore
#line 97 "D:\FinalFix\AWork.Web\Views\PersonCreditCards\Index.cshtml"
                                                                                                                       Write(ViewBag.CurrentSort);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<AWork.Contracts.Dto.Sales.PersonCreditCard.PersonCreditCardDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

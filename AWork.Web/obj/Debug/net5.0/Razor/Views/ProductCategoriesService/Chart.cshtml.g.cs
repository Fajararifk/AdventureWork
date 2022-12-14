#pragma checksum "D:\FinalFix\AWork.Web\Views\ProductCategoriesService\Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a191d2e200b8b9872e21531cee2946e0450ce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductCategoriesService_Chart), @"mvc.1.0.view", @"/Views/ProductCategoriesService/Chart.cshtml")]
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
#line 1 "D:\FinalFix\AWork.Web\Views\ProductCategoriesService\Chart.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a191d2e200b8b9872e21531cee2946e0450ce9", @"/Views/ProductCategoriesService/Chart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1683cd99f6100561ab4f2b698f40be1084e5b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductCategoriesService_Chart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AWork.Contracts.Dto.Production.ProductSubCategoryDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container p-3 my-3\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"col-sm-4\">\r\n                <label class=\"control-label\">CategoryName</label>\r\n                ");
#nullable restore
#line 8 "D:\FinalFix\AWork.Web\Views\ProductCategoriesService\Chart.cshtml"
           Write(Html.DropDownList("ProductSubcategoryId",ViewBag.Name,"",
            new{@class="form-select", id="subcategory"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""container p-3 my-3"">
    <div class=""card"">
        <div id=""chart""></div>
    </div>
</div>
<div class=""container p-3 my-3"">
    <div class=""card"">
        <div id=""chart2""></div>
    </div>
</div>





");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

<script>
    $(document).ready(function () {
         //renderChart();
         let totalProduct =[];
         let categoris =[];
         let category= $('#category').val();
          $.ajax({
               type : 'GET',
               url: '/ProductCategoriesService/GetSubcategoriesById/?category='+category,
               success : function (result){
               console.log(result);
                   for (let i=0; i < result.length; i++){
                   totalProduct.push(result[i].totalProduct);
                   categoris.push(result[i].subCategory);
                   }
                   console.log(totalProduct);
                   console.log(categoris);
                   renderBarChart(totalProduct,categoris);
                 //renderPieChart(totalProduct,categories);

                        let totProduct =[];
                        let categories =[];
                        let subcategory = $(""#subcategory"");
                            subcategory.change(");
                WriteLiteral(@"function () {
                                $.ajax({
                                    type: ""GET"",
                                    url: '/ProductCategoriesService/GetTotalProductBySub/?subcategory='+subcategory.val(),
                                    success: function (result) {
                                        console.log(result);
                                        for (let i = 0; i < result.length; i++) {
                                            totProduct.push(result[i].totalProduct)
                                            categories.push(result[i].subcategory)
                                        }
                                        console.log(totProduct);
                                        console.log(categories);
                                        renderBarChart1(totProduct,categories);
                                        //renderPieChart(totalProducts,categories);
                                    },
                                ");
                WriteLiteral(@"    error: function (result) {
                                        console.log(result);
                                    }
                                });
              
                          })
                }
               })
         function renderBarChart(dataSeries, dataCategories) {
               var options = {
               series: [{
               data: dataSeries
               }],
               chart: {
               height: 350,
               type: 'bar',
               events: {
               click: function(chart, w, e) {
               // console.log(chart, w, e)
               }
               }
               },
               plotOptions: {
                    bar: {
                      columnWidth: '45%',
                      distributed: true,
                      }
                      },
                      dataLabels: {
                      enabled: false
                      },
                      legend:
            ");
                WriteLiteral(@"          {
                      show: false
                      },
                  xaxis: {
                  categories: dataCategories,
                  }
                  };
                  var chart = new ApexCharts(document.querySelector(""#chart""), options);
                  chart.render();
                  }



                  function renderBarChart1(dataSeries, dataCategories) {
            var options = {
                series: [{
                    data: dataSeries
                }],
                 chart: {
                    type: 'bar',
                    height: 350
                },
                plotOptions: {
                        bar: {
                    borderRadius: 4,
                    horizontal: true,
                    }
                },
                dataLabels: {
                   enabled: false
                },
                xaxis: {
                categories: dataCategories,
                }
                ");
                WriteLiteral("};\r\n\r\n                var chart = new ApexCharts(document.querySelector(\"#chart2\"), options);\r\n                chart.render();\r\n                }\r\n\r\n    })\r\n   \r\n\r\n   \r\n\r\n\r\n</script>\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AWork.Contracts.Dto.Production.ProductSubCategoryDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

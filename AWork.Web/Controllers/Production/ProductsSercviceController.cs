using AWork.Contracts.Dto.Production;
using AWork.Persistence;
using AWork.Services.Abstraction;
using AWork.Services.Abstraction.Production;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace AWork.Web.Controllers.Production
{
    public class ProductsSercviceController : Controller
    {
        private readonly AdventureWorks2019Context _context;
        private readonly IProductionServiceManager _productionServiceContext;
        private readonly IUtilityService _utilityService;

        public ProductsSercviceController(AdventureWorks2019Context context, IProductionServiceManager productionServiceContext = null, IUtilityService utilityService = null)
        {
            _context = context;
            _productionServiceContext = productionServiceContext;
            _utilityService = utilityService;
        }

        // GET: ProductsSercvice
        public async Task<IActionResult> Index(string sortOrder, string searchString,
            string currentFilter, int? page, int? pagesize)
        {
            // set page
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            // default size is 5 otherwise take pageSize value  
            int defaSize = (pagesize ?? 5);
            ViewBag.psize = defaSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.currentFilter = searchString;

            //var prodDtos = await _productionServiceContext.ProductService.GetProductPaged(pageIndex, defaSize, false);
            //Create a instance of our DataContext  
            var productDtos = await _productionServiceContext.ProductService.GetAllProduct(false);
            //IPagedList<ProductDto> products = null;

            //var totalRows = productDtos.Count();

            //var totalRows = prod.Count();

            if (!string.IsNullOrEmpty(searchString))
            {
                productDtos = productDtos.Where(p => p.Name.ToLower().Contains(searchString.ToLower()) ||
                     p.ProductNumber.ToLower().Contains(searchString.ToLower())); /*||
                p.ProductSubcategory.Name.ToLower().Contains(searchString.ToLower()));*/
            }

            //Dropdownlist code for PageSize selection  
            //In View Attach this  
            ViewBag.PageSize = new List<SelectListItem>()
            {
                new SelectListItem() { Value="5", Text= "5" },
                new SelectListItem() { Value="10", Text= "10" },
                new SelectListItem() { Value="15", Text= "15" },
                new SelectListItem() { Value="20", Text= "20" }
            };


            // Sort Data
            ViewBag.NameProductSort = String.IsNullOrEmpty(sortOrder) ? "product_name" : "";
            ViewBag.UnitPriceSort = sortOrder == "UnitPrice" ? "unitPrice_desc" : "UnitPrice";

            switch (sortOrder)
            {
                case "product_name":
                    productDtos = productDtos.OrderByDescending(s => s.Name);
                    break;
                case "UnitProduct_desc":
                    productDtos = productDtos.OrderBy(s => s.ProductNumber);
                    break;
                default:
                    productDtos = productDtos.OrderBy(s => s.Name);
                    break;
            }

            //Alloting nos. of records as per pagesize and page index.  
            //productDtos = products.ToPagedList(pageIndex, defaSize);
            return View(productDtos.ToPagedList(pageIndex, defaSize));
            //return View(productDtosPaged);


           
        }

        // GET: ProductsSercvice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productionServiceContext.ProductService.GetProductById((int)id, false);
           
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public async Task<IActionResult>CreateProductPhoto(UploadImages uploadImages)
        {

            if (ModelState.IsValid)
            {
                /*var uploadImagesDto1 = uploadImages;
                var Photo1 = new ProductPhotoForCreateDto();

                var photos = uploadImagesDto1.Photo1;
                var fileName1 = _utilityService.UploadSingleFile(photos);
                var photo1 = new ProductPhotoForCreateDto
                {
                    ThumbnailPhotoFileName = fileName1,
                    LargePhotoFileName = photos.FileName,
                    LargePhoto = ((byte)photos.Length),
                    ModifiedDate = System.DateTime.Now

                 };*/

          
                

                var uploadImagesDto = uploadImages;
                var listPhoto = new List<ProductPhotoForCreateDto>();

                foreach (var itemPhoto in uploadImagesDto.FileImages)
                {
                    var fileName = _utilityService.UploadSingleFile(itemPhoto);
                    var photo = new ProductPhotoForCreateDto
                    {
                        ThumbnailPhotoFileName = fileName,
                        LargePhotoFileName = itemPhoto.FileName,
                        LargePhoto = ((byte)itemPhoto.Length),
                        ModifiedDate = System.DateTime.Now
                    };

                    listPhoto.Add(photo);

                }
                _productionServiceContext.ProductService.CreateProductIdPhoto(uploadImagesDto.ProductFCDto, uploadImagesDto.ProductProductPhotoFCDto, listPhoto);
            }
                return RedirectToAction(nameof(Index));
        }
            // GET: ProductsSercvice/Create
            public async Task<IActionResult> CreateAsync()
        {
            //ViewData["ProductModelId"] = new SelectList(_context.ProductModels, "ProductModelId", "Name");
            ViewData["ProductSubcategoryId"] = new SelectList(await _productionServiceContext.ProductSubCategoryService.GetAllProdcSubCategory(false), "ProductSubcategoryId", "Name");
            ViewData["SizeUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(false), "UnitMeasureCode", "UnitMeasureCode");
            ViewData["WeightUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(false), "UnitMeasureCode", "UnitMeasureCode");
            ViewBag.Style = new List<SelectListItem>()
            {
                new SelectListItem() { Value="W", Text= "Women" },
                new SelectListItem() { Value="M", Text= "Man" },
                new SelectListItem() { Value="U", Text= "Universal" }
            };
            ViewBag.Class = new List<SelectListItem>()
            {
                new SelectListItem() { Value="H", Text= "High" },
                new SelectListItem() { Value="M", Text= "Medium" },
                new SelectListItem() { Value="L", Text= "low" }
            };
            ViewBag.ProductLine = new List<SelectListItem>()
            {
                new SelectListItem() { Value="R", Text= "Road" },
                new SelectListItem() { Value="M", Text= "Mountain" },
                new SelectListItem() { Value="T", Text= "Touring" },
                new SelectListItem() { Value="S", Text= "Standar" }
            };
            ViewBag.Size = new List<SelectListItem>()
            {
                new SelectListItem() { Value="S", Text= "Small" },
                new SelectListItem() { Value="M", Text= "Medium" },
                new SelectListItem() { Value="L", Text= "Large" },
                new SelectListItem() { Value="XL", Text= "XtraLarge" }
            };
            ViewBag.Color = new List<SelectListItem>()
            {
                new SelectListItem() { Value="Red", Text= "Red" },
                new SelectListItem() { Value="Black", Text= "Black" },
                new SelectListItem() { Value="Blue", Text= "Blue" },
                new SelectListItem() { Value="White", Text= "White" },
                new SelectListItem() { Value="Pink", Text= "Pink" },
                new SelectListItem() { Value="Silver", Text= "Silver" },
                new SelectListItem() { Value="Purple", Text= "Purple" },
                new SelectListItem() { Value="Green", Text= "Green" },
                new SelectListItem() { Value="Yellow", Text= "Yellow" }
            };
            return View();
        }

        // POST: ProductsSercvice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryId,ProductModelId,SellStartDate,SellEndDate,DiscontinuedDate,Rowguid,ModifiedDate")] ProductForCreateDto productForCreateDto)
        //public async Task<IActionResult> Create([Bind("ProductId,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryId,ProductModelId,SellStartDate,SellEndDate,DiscontinuedDate,Rowguid,ModifiedDate")] ProductForCreateDto productForCreateDto)

        {
            if (ModelState.IsValid)
            {
                /* _context.Add(product);
                 await _context.SaveChangesAsync();*/
                _productionServiceContext.ProductService.Insert(productForCreateDto);
                return RedirectToAction(nameof(Index));
            }

            ViewData["ProductSubcategoryId"] = new SelectList(await _productionServiceContext.ProductSubCategoryService.GetAllProdcSubCategory(false), "ProductSubcategoryId", "Name", productForCreateDto.ProductSubcategoryId);
            ViewData["SizeUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(false), "UnitMeasureCode", "UnitMeasureCode", productForCreateDto.SizeUnitMeasureCode);
            ViewData["WeightUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(false), "UnitMeasureCode", "UnitMeasureCode", productForCreateDto.WeightUnitMeasureCode);

            return View(productForCreateDto);
        }

        // GET: ProductsSercvice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _productionServiceContext.ProductService.GetProductById((int)id, true);
            //var product = await _context.Products.FindAsync(id);

            //var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductSubcategoryId"] = new SelectList(await _productionServiceContext.ProductSubCategoryService.GetAllProdcSubCategory(true), "ProductSubcategoryId", "Name", product.ProductSubcategoryId);
            ViewData["SizeUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(true), "UnitMeasureCode", "UnitMeasureCode", product.SizeUnitMeasureCode);
            ViewData["WeightUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(true), "UnitMeasureCode", "UnitMeasureCode", product.WeightUnitMeasureCode);
           
            return View(product);
        }

        // POST: ProductsSercvice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,ProductModelId,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryId,SellStartDate,SellEndDate,DiscontinuedDate,Rowguid,ModifiedDate")] ProductDto productDto)
        {
            if (id != productDto.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  
                    _productionServiceContext.ProductService.Edit(productDto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(productDto.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductSubcategoryId"] = new SelectList(await _productionServiceContext.ProductSubCategoryService.GetAllProdcSubCategory(true), "ProductSubcategoryId", "Name", productDto.ProductSubcategoryId);
            ViewData["SizeUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(true), "UnitMeasureCode", "UnitMeasureCode", productDto.SizeUnitMeasureCode);
            ViewData["WeightUnitMeasureCode"] = new SelectList(await _productionServiceContext.UnitMeasureservice.GetAllUnitMeasure(true), "UnitMeasureCode", "UnitMeasureCode", productDto.WeightUnitMeasureCode);


            return View(productDto);
        }

        // GET: ProductsSercvice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _productionServiceContext.ProductService.GetProductById((int)id, false);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: ProductsSercvice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            var productModel = await _productionServiceContext.ProductService.GetProductById((int)id, false);
            _productionServiceContext.ProductService.Remove(productModel);
           /* var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();*/
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}

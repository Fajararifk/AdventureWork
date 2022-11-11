using AWork.Contracts.Dto.Production;
using AWork.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using X.PagedList;
using System.Linq;
using AWork.Contracts.Dto.Sales.ShoppingCartItem;
using Microsoft.AspNetCore.Identity;
using AWork.Domain.Models;
using AWork.Domain.Base;

namespace AWork.Web.Controllers.Sales
{
    public class ProductOnSaleController : Controller
    {
        private readonly ISalesServiceManager salesServiceManager;
        private readonly IProductionServiceManager productServiceManager;
        private readonly UserManager<User> _userManager;
        private readonly IPersonServiceManager _servisManager;

        public ProductOnSaleController(ISalesServiceManager salesServiceManager, IProductionServiceManager productServiceManager, UserManager<User> userManager, IPersonServiceManager servisManager)
        {
            this.salesServiceManager = salesServiceManager;
            this.productServiceManager = productServiceManager;
            _userManager = userManager;
            _servisManager = servisManager;
        }

        public async Task<IActionResult> Index(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            // set page
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            // default size is 5 otherwise take pageSize value
            int defaultSize = (pageSize ?? 5);
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var productDto = await salesServiceManager.ShoppingCartItemService.GetProductOnSales(false);
            IPagedList<ProductDto> productDtos = null;

            if (!String.IsNullOrEmpty(searchString))
            {
                productDto = productDto.Where(c =>
                c.Name.ToLower().Contains(searchString.ToLower()) ||
                c.ProductId.ToString().Contains(searchString.ToString())

               
                );
            }

            ViewBag.PageSize = new List<SelectListItem>()
            {
                new SelectListItem() { Value="5", Text= "5" },
                new SelectListItem() { Value="10", Text= "10" },
                new SelectListItem() { Value="15", Text= "15" },
                new SelectListItem() { Value="20", Text= "20" }
            };

            // sort data
            ViewBag.Territory = sortOrder == "ShoppingCartItems" ? "" : "ShoppingCartItems";
            ViewBag.CurrentSort = sortOrder;
            switch (sortOrder)
            {
                case "ShoppingCartItems":
                    productDto = productDto.OrderBy(s => s.Name);
                    break;
                default:
                    productDto = productDto.OrderByDescending(s => s.Name);
                    break;
            }

            productDtos = productDto.ToPagedList(pageIndex, defaultSize);
            return View(productDtos);
        }

        // GET: ProductOnSale/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await productServiceManager.ProductService.GetProductById((int)id, false);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        [HttpPost]
        public async Task<IActionResult> AddToCart(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                var myUser = await _userManager.GetUserAsync(User);
                var email = await _servisManager.EmailAddressServices.GetEmailAddress(myUser.Email, false);
                int businessEntityId = email.BusinessEntityId;
                string custId = Convert.ToString(businessEntityId);
                var cekCust = await salesServiceManager.ShoppingCartItemService.FilterCustId(custId, false);
                var products = productDto;
                // create ShoppingCartItem, jika customer belum melakukan order dengan mengecek filter by customer id (jika null maka create baru)
                if (cekCust.Count() == 0)
                {
                    var cartItem = new ShoppingCartItemForCreateDto
                    {
                        ProductId = products.ProductId,
                        Quantity = 1,
                        ShoppingCartId = custId,
                        DateCreated = DateTime.Now,
                        ModifiedDate = DateTime.Now
                    };
                    salesServiceManager.ShoppingCartItemService.Insert(cartItem);
                }

                else
                {
                    ShoppingCartItemDto shopping = new ShoppingCartItemDto();
                    ShoppingCartItemForCreateDto shoppingCreate = new ShoppingCartItemForCreateDto();
                    foreach (var item in cekCust)
                    {
                        // melakukan cart dengan product yang sama
                        if (item.ProductId == products.ProductId)
                        {
                            var quantity = item.Quantity;
                            shopping.ShoppingCartId = custId;
                            shopping.ShoppingCartItemId = item.ShoppingCartItemId;
                            shopping.DateCreated = item.DateCreated;
                            shopping.ModifiedDate = DateTime.Now;
                            shopping.ProductId = products.ProductId;
                            shopping.Quantity = quantity + 1;
                            salesServiceManager.ShoppingCartItemService.Edit(shopping);
                        }
                        // melakukan add cart dengan product yang berbeda
                        else
                        {
                            shoppingCreate.ProductId = products.ProductId;
                            shoppingCreate.Quantity = 1;
                            shoppingCreate.ShoppingCartId = custId;
                            shoppingCreate.DateCreated = DateTime.Now;
                            shoppingCreate.ModifiedDate = DateTime.Now;
                        };
                    }
                    if (shopping.ProductId != shoppingCreate.ProductId)
                    {
                        salesServiceManager.ShoppingCartItemService.Insert(shoppingCreate);
                    }
                }
            }
            return RedirectToAction("Index", "ProductOnSale");
        }
    }
}

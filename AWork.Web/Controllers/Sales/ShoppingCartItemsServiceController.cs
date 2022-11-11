using AWork.Contracts.Dto.Sales.PersonCreditCard;
using AWork.Contracts.Dto.Sales.ShoppingCartItem;
using AWork.Domain.Base;
using AWork.Domain.Models;
using AWork.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using X.PagedList;
using AWork.Contracts.Dto.Production;
using Microsoft.AspNetCore.Identity;

namespace AWork.Web.Controllers.Sales
{
    public class ShoppingCartItemsServiceController : Controller
    {
        private readonly ISalesServiceManager _context;
        private readonly UserManager<User> _userManager;
        private readonly IPersonServiceManager _servisManager;

        public ShoppingCartItemsServiceController(ISalesServiceManager context, UserManager<User> userManager, IPersonServiceManager servisManager)
        {
            _context = context;
            _userManager = userManager;
            _servisManager = servisManager;
        }

        public async Task<IActionResult> CartItem()
        {
            var myUser = await _userManager.GetUserAsync(User);
            var email = await _servisManager.EmailAddressServices.GetEmailAddress(myUser.Email, false);
            int businessEntityId = email.BusinessEntityId;
            var customerId = Convert.ToString(businessEntityId);
            var itemCart = await _context.ShoppingCartItemService.GetCartItemByCustId(customerId, false);
            return View(itemCart);
        }

        // GET: ShoppingCartItemsRepository/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shoppingCartItem = await _context.ShoppingCartItemService.GetShopCartItemById((int)id, false);
            if (shoppingCartItem == null)
            {
                return NotFound();
            }

            return View(shoppingCartItem);
        }

        // POST: ShoppingCartItemsRepository/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoppingCartItem = await _context.ShoppingCartItemService.GetShopCartItemById((int)id, false);
            _context.ShoppingCartItemService.Remove(shoppingCartItem);
            return RedirectToAction(nameof(Index));
        }
    }
}

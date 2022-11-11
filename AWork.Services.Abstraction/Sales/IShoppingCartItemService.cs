using AWork.Contracts.Dto.Production;
using AWork.Contracts.Dto.Sales.SalesPerson;
using AWork.Contracts.Dto.Sales.ShoppingCartItem;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Sales
{
    public interface IShoppingCartItemService
    {
        Task<IEnumerable<ShoppingCartItemDto>> GetAllShopCartItem(bool trackChanges);

        Task<IEnumerable<ShoppingCartItemDto>> FilterCustId(string custId, bool trackChanges);

        Task<IEnumerable<ProductDto>> GetProductOnSales(bool trackChanges);

        Task<IEnumerable<ShoppingCartItemDto>> GetCartItemByCustId(string custId, bool trackChanges);

        Task<ShoppingCartItemDto> GetShopCartItemById(int shopCartItemId, bool trackChanges);

        Task<ShoppingCartItemDto> GetDataCartCustomerById(int shoppingCartId, int productId, bool trackChanges);

        void Insert(ShoppingCartItemForCreateDto shopCartItemForCreateDto);

        void Edit(ShoppingCartItemDto shopCartItemDto);

        void Remove(ShoppingCartItemDto shopCartItemDto);
    }
}

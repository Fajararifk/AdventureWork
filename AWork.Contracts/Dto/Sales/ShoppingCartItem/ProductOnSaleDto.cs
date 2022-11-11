using AWork.Contracts.Dto.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Contracts.Dto.Sales.ShoppingCartItem
{
    public class ProductOnSaleDto
    {
        public ProductDto productDto { get; set; }
        public ShoppingCartItemForCreateDto shoppingCartItem { get; set; }
    }
}

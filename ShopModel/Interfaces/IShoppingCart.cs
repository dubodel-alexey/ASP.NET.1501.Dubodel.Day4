using System.Collections.Generic;

namespace ShopModel.Interfaces
{
    public interface IShoppingCart
    {
        IEnumerable<IProduct> Products { get; set; }
        decimal CalculateProductTotal();
    }
}

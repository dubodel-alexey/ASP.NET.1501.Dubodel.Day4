using System.Collections.Generic;
using ShopModel.Interface;

namespace ShopModel.Interfaces
{
    public interface ICalculator
    {
        decimal ValueProducts(IEnumerable<IProduct> products, IDiscount discount);
    }
}

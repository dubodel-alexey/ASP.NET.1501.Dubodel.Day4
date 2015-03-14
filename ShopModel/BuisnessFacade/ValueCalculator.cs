using System;
using System.Collections.Generic;
using System.Linq;
using ShopModel.Interfaces;

namespace ShopModel.BuisnessFacade
{
    public class ValueCalculator : ICalculator
    {
        public decimal ValueProducts(IEnumerable<IProduct> products, IDiscount discount)
        {
            if (products == null)
            {
                throw new ArgumentNullException("products");
            }
            if (discount == null)
            {
                throw new ArgumentNullException("discount");
            }
            return decimal.Multiply(products.Sum(product => product.Price), (decimal)(1 - discount.Discount));
        }
    }
}

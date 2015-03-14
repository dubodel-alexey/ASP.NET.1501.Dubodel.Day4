using System;
using System.Collections.Generic;
using System.Linq;
using ShopModel.Interfaces;

namespace ShopModel.BuisnessFacade
{
    class ValueCalculatorHalfPrice : ICalculator
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
            return decimal.Multiply(products.Sum(product => product.Price) / 2, (decimal)(1 - discount.Discount));
        }
    }
}

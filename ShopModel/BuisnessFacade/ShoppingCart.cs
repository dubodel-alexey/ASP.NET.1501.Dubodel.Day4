using System;
using System.Collections.Generic;
using ShopModel.Interfaces;

namespace ShopModel.BuisnessFacade
{
    public class ShoppingCart : IShoppingCart
    {
        private ICalculator valueCalculator;
        private IDiscount discount;

        public IEnumerable<IProduct> Products { get; set; }

        public ShoppingCart(ICalculator valueCalculator, IDiscount discount)
        {
            if (valueCalculator == null)
            {
                throw new ArgumentNullException("valueCalculator");
            }
            if (discount == null)
            {
                throw new ArgumentNullException("discount");
            }
            this.valueCalculator = valueCalculator;
            this.discount = discount;
        }

        public decimal CalculateProductTotal()
        {
            return valueCalculator.ValueProducts(Products, discount);
        }
    }
}

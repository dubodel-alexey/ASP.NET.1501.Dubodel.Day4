using System;
using System.Collections.Generic;
using Ninject;
using ShopModel.BuisnessFacade;
using ShopModel.Configuration;
using ShopModel.Interface;
using ShopModel.Interfaces;

namespace ShopModel
{
    class Program
    {
        static void Main()
        {
            IKernel kernel2 = new StandardKernel(new ConfigModule());
            var cart = kernel2.Get<ShoppingCart>();

            cart.Products = new List<IProduct>()
            {
                new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
            };

            Console.WriteLine("Total price = {0}$", cart.CalculateProductTotal());
            Console.ReadKey();
        }
    }
}

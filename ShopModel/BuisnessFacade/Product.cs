using ShopModel.Interfaces;

namespace ShopModel.BuisnessFacade
{
    public class Product : IProduct
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { set; get; }
    }
}

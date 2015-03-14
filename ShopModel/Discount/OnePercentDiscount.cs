using ShopModel.Interfaces;

namespace ShopModel.Discount
{
    class OnePercentDiscount : IDiscount
    {
        public double Discount { get { return 0.01; } }
    }
}

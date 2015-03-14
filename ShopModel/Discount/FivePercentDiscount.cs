using ShopModel.Interfaces;

namespace ShopModel.Discount
{
    class FivePercentDiscount : IDiscount
    {
        public double Discount { get { return 0.05; } }
    }
}

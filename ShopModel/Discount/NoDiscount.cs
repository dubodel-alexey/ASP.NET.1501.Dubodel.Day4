using ShopModel.Interfaces;

namespace ShopModel.Discount
{
    class NoDiscount : IDiscount
    {
        public double Discount
        {
            get { return 0.0; }
        }
    }
}

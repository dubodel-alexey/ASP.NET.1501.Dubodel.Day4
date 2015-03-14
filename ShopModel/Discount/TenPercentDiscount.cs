using ShopModel.Interfaces;

namespace ShopModel.Discount
{
    class TenPercentDiscount : IDiscount    
    {
        public double Discount { get { return 0.1; } }
    }
}

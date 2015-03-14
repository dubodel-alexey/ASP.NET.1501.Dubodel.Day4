using Ninject.Modules;
using ShopModel.BuisnessFacade;
using ShopModel.Discount;
using ShopModel.Interfaces;

namespace ShopModel.Configuration
{
    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ICalculator>().To<ValueCalculator>();
            this.Bind<IDiscount>().To<TenPercentDiscount>();
        }
    }
}

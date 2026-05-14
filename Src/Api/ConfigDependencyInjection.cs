using Api.Services.CoffeeProducerService;
using Api.Services.BatchCoffeeProducerService;
using Api.Services.PurchaseService;

namespace Api
{
    public static class ConfigDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            CoffeeProducerDependencyInjection.Config(services);
            BatchCoffeeProducerDependencyInjection.Config(services);
            PurchaseDependencyInjection.Config(services);
        }
    }
}

using Api.Services.CoffeeProducerService;
using Api.Services.BatchCoffeeProducerService;
using Api.Services.PurchaseService;
using Api.Services.CoffeeVarietyService;
using Api.Services.CoffeeTypeService;
using Api.Services.MeasurementUnitCoffeeService;

namespace Api
{
    public static class ConfigDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            CoffeeProducerDependencyInjection.Config(services);
            BatchCoffeeProducerDependencyInjection.Config(services);
            PurchaseDependencyInjection.Config(services);
            CoffeeVarietyDependencyInjection.Config(services);
            CoffeeTypeDependencyInjection.Config(services);
            MeasurementUnitCoffeeDependencyInjection.Config(services);
        }
    }
}

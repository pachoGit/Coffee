using Api.Services.CoffeeProducerService;
using Api.Services.BatchCoffeeProducerService;
using Api.Services.PurchaseService;
using Api.Services.CoffeeVarietyService;
using Api.Services.CoffeeTypeService;
using Api.Services.MeasurementUnitCoffeeService;
namespace Api
{
    public static class CoffeeEndpointBuilder
    {
        public static void Build(WebApplication app)
        {
            CoffeProducerEndpoint.Endpoints(app);
            BatchCoffeeProducerEndpoint.Endpoints(app);
            PurchaseServiceEndpoint.Endpoints(app);
            CoffeeVarietyEndpoint.Endpoints(app);
            CoffeeTypeEndpoint.Endpoints(app);
            MeasurementUnitCoffeeEndpoint.Endpoints(app);
        }
    }
}

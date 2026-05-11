using Api.Services.CoffeeProducerService;
using Api.Services.BatchCoffeeProducerService;
using Api.Services.PurchaseService;
namespace Api
{
    public static class CoffeeEndpointBuilder
    {
        public static void Build(WebApplication app)
        {
            CoffeProducerEndpoint.Endpoints(app);
            BatchCoffeeProducerEndpoint.Endpoints(app);
            PurchaseServiceEndpoint.Endpoints(app);
        }
    }
}

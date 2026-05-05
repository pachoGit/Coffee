using Api.Services.CoffeeProducerService;

namespace Api
{
    public static class CoffeeEndpointBuilder
    {
        public static void Build(WebApplication app)
        {
            CoffeProducerEndpoint.Endpoints(app);
        }
    }
}

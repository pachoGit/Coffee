using Api.Services.CoffeeProducerService.CreateCoffeeProducer;
using Api.Services.CoffeeProducerService.ListCoffeeProducer;

namespace Api.Services.CoffeeProducerService
{
    public static class CoffeProducerEndpoint
    {
        private static RouteGroupBuilder RouteGroup(WebApplication app)
        {
            return app.MapGroup("/api/coffee-producer");
        }

        public static void Endpoints(WebApplication app)
        {
            var routeGroup = RouteGroup(app);
            CreateCoffeeProducerEndpoint.Endpoint(routeGroup);
            ListCoffeeProducerEndpoint.Endpoint(routeGroup);
        }
    }
}

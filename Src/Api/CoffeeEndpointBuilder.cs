using Api.Services.CoffeeProducerService;

namespace Api
{
    public static class CoffeeEndpointBuilder
    {
        public static void Build(WebApplication app)
        {
            Console.WriteLine("Creando todos los endpoints");
            CoffeProducerEndpoint.Endpoints(app);
        }
    }
}

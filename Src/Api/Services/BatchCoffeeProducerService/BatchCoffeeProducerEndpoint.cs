namespace Api.Services.BatchCoffeeProducerService
{
    public static class BatchCoffeeProducerEndpoint
    {
        private static RouteGroupBuilder RouteGroup(WebApplication app)
        {
            return app.MapGroup("/api/batch-coffee-producer");
        }

        public static void Endpoints(WebApplication app)
        {

        }
    }
}

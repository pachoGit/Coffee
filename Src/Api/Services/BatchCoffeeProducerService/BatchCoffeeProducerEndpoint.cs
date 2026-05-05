namespace Api.Services.BatchCoffeeProducerService
{
    using Api.Services.BatchCoffeeProducerService.CreateBatchCoffeeProducer;
    using Api.Services.BatchCoffeeProducerService.ListBatchCoffeeProducer;
    using Api.Services.BatchCoffeeProducerService.GetBatchCoffeeProducerById;
    using Api.Services.BatchCoffeeProducerService.UpdateBatchCoffeeProducer;
    using Api.Services.BatchCoffeeProducerService.DeleteBatchCoffeeProducer;

    public static class BatchCoffeeProducerEndpoint
    {
        private static RouteGroupBuilder RouteGroup(WebApplication app)
        {
            return app.MapGroup("/api/batch-coffee-producer");
        }

        public static void Endpoints(WebApplication app)
        {
            var routeGroup = RouteGroup(app);
            CreateBatchCoffeeProducerEndpoint.Endpoint(routeGroup);
            ListBatchCoffeeProducerEndpoint.Endpoint(routeGroup);
            GetBatchCoffeeProducerByIdEndpoint.Endpoint(routeGroup);
            UpdateBatchCoffeeProducerEndpoint.Endpoint(routeGroup);
            DeleteBatchCoffeeProducerEndpoint.Endpoint(routeGroup);
        }
    }
}

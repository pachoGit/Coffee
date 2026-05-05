using Microsoft.AspNetCore.Mvc;

namespace Api.Services.BatchCoffeeProducerService.ListBatchCoffeeProducer
{
    public static class ListBatchCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/list", async (ListBatchCoffeeProducerHandler handler) =>
            {
                ListBatchCoffeeProducerRequest request = new();
                var result = await handler.Handle(request);
                return Results.Ok(result);
            });
        }
    }
}
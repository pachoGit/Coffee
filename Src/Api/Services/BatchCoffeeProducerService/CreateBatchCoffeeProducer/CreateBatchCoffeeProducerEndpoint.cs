using Microsoft.AspNetCore.Mvc;

namespace Api.Services.BatchCoffeeProducerService.CreateBatchCoffeeProducer
{
    public static class CreateBatchCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapPost("/", async ([FromBody] CreateBatchCoffeeProducerRequest request, CreateBatchCoffeeProducerHandler handler) =>
            {
                var id = await handler.Handle(request);
                return Results.Created($"/api/batch-coffee-producer/{id}", new { Id = id });
            });
        }
    }
}
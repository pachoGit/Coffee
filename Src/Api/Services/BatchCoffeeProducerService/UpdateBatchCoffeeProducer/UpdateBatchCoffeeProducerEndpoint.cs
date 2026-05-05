using Microsoft.AspNetCore.Mvc;

namespace Api.Services.BatchCoffeeProducerService.UpdateBatchCoffeeProducer
{
    public static class UpdateBatchCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapPut("/{id}", async ([FromRoute] int id, [FromBody] UpdateBatchCoffeeProducerRequest request, UpdateBatchCoffeeProducerHandler handler) =>
            {
                request.Id = id;
                var result = await handler.Handle(request);
                return result != null ? Results.Ok(result) : Results.NotFound();
            });
        }
    }
}
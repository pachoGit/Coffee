using Microsoft.AspNetCore.Mvc;

namespace Api.Services.BatchCoffeeProducerService.DeleteBatchCoffeeProducer
{
    public static class DeleteBatchCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapDelete("/{id}", async ([FromRoute] int id, DeleteBatchCoffeeProducerHandler handler) =>
            {
                var result = await handler.Handle(id);
                return result ? Results.NoContent() : Results.NotFound();
            });
        }
    }
}
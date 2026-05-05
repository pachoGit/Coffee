using Microsoft.AspNetCore.Mvc;

namespace Api.Services.BatchCoffeeProducerService.GetBatchCoffeeProducerById
{
    public static class GetBatchCoffeeProducerByIdEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/{id}", async ([FromRoute] int id, GetBatchCoffeeProducerByIdHandler handler) =>
            {
                var result = await handler.Handle(id);
                return result != null ? Results.Ok(result) : Results.NotFound();
            });
        }
    }
}
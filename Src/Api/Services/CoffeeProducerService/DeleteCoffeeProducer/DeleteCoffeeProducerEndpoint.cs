using Microsoft.AspNetCore.Mvc;

namespace Api.Services.CoffeeProducerService.DeleteCoffeeProducer
{
    public static class DeleteCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapDelete("/{id}", async ([FromRoute] int id, DeleteCoffeeProducerHandler handler) =>
            {
                var result = await handler.Handle(id);
                return result ? Results.NoContent() : Results.NotFound();
            });
        }
    }
}
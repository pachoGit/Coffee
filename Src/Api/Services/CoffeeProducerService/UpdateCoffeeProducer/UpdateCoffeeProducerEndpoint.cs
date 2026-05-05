using Microsoft.AspNetCore.Mvc;

namespace Api.Services.CoffeeProducerService.UpdateCoffeeProducer
{
    public static class UpdateCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapPut("/{id}", async ([FromRoute] int id, [FromBody] UpdateCoffeeProducerRequest request, UpdateCoffeeProducerHandler handler) =>
            {
                request.Id = id;
                var result = await handler.Handle(request);
                return result != null ? Results.Ok(result) : Results.NotFound();
            });
        }
    }
}
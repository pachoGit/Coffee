using Api.Services.Common;
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
                return result != null 
                    ? Results.Ok(new CoffeeResponse<UpdateCoffeeProducerResponse>(result, "Coffee producer updated successfully"))
                    : Results.NotFound(new CoffeeResponse<UpdateCoffeeProducerResponse>(null!, "Coffee producer not found"));
            });
        }
    }
}
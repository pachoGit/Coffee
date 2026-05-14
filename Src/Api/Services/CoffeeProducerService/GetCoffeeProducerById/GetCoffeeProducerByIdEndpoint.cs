using Api.Services.Common;
using Microsoft.AspNetCore.Mvc;

namespace Api.Services.CoffeeProducerService.GetCoffeeProducerById
{
    public static class GetCoffeeProducerByIdEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/{id}", async ([FromRoute] int id, GetCoffeeProducerByIdHandler handler) =>
            {
                var result = await handler.Handle(id);
                return result != null 
                    ? Results.Ok(new CoffeeResponse<GetCoffeeProducerByIdResponse>(result, "Coffee producer retrieved successfully"))
                    : Results.NotFound(new CoffeeResponse<GetCoffeeProducerByIdResponse>(null!, "Coffee producer not found"));
            });
        }
    }
}
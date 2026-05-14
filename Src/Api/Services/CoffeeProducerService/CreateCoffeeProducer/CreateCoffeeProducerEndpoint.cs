using Api.Services.Common;
using Microsoft.AspNetCore.Mvc;

namespace Api.Services.CoffeeProducerService.CreateCoffeeProducer
{
    public static class CreateCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapPost("/", async ([FromBody] CreateCoffeeProducerRequest request, CreateCoffeeProducerHandler handler) =>
            {
                var id = await handler.Handle(request);
                return Results.Created($"/api/coffee-producers/{id}", new CoffeeResponse<int>(id, "Coffee producer created successfully"));
            });
        }
    }
}

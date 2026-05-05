using Microsoft.AspNetCore.Mvc;

namespace Api.Services.CoffeeProducerService.ListCoffeeProducer
{
    public static class ListCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/list", async (ListCoffeeProducerHandler handler) =>
            {
                ListCoffeeProducerRequest request = new();
                var result = await handler.Handle(request);
                return Results.Ok(result);
            });
        }
    }
}

using Api.Services.Common;

namespace Api.Services.CoffeeProducerService.SelectCoffeeProducer
{
    public static class SelectCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/select", async (SelectCoffeeProducerHandler handler) =>
            {
                var result = await handler.Handle();
                return Results.Ok(new CoffeeResponse<SelectCoffeeProducerResponse>(result, "Coffee producers retrieved successfully"));
            });
        }
    }
}
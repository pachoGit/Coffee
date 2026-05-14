using Api.Services.Common;

namespace Api.Services.CoffeeProducerService.ListCoffeeProducer
{
    public static class ListCoffeeProducerEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/list", async ([AsParameters] ListCoffeeProducerRequest request, ListCoffeeProducerHandler handler) =>
            {
                var result = await handler.Handle(request);
                return Results.Ok(new CoffeeResponse<List<ListCoffeeProducerResponse>>(result, "Coffee producers retrieved successfully"));
            });
        }
    }
}

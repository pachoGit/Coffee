using Api.Services.Common;

namespace Api.Services.CoffeeVarietyService.SelectCoffeeVariety
{
    public static class SelectCoffeeVarietyEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/select", async (SelectCoffeeVarietyHandler handler) =>
            {
                var result = await handler.Handle();
                return Results.Ok(new CoffeeResponse<SelectCoffeeVarietyResponse>(result, "Coffee varieties retrieved successfully"));
            });
        }
    }
}
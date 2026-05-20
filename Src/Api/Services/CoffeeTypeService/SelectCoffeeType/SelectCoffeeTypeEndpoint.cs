using Api.Services.Common;

namespace Api.Services.CoffeeTypeService.SelectCoffeeType
{
    public static class SelectCoffeeTypeEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/select", async (SelectCoffeeTypeHandler handler) =>
            {
                var result = await handler.Handle();
                return Results.Ok(new CoffeeResponse<SelectCoffeeTypeResponse>(result, "Coffee types retrieved successfully"));
            });
        }
    }
}
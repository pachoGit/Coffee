using Api.Services.Common;

namespace Api.Services.MeasurementUnitCoffeeService.SelectMeasurementUnitCoffee
{
    public static class SelectMeasurementUnitCoffeeEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/select", async (SelectMeasurementUnitCoffeeHandler handler) =>
            {
                var result = await handler.Handle();
                return Results.Ok(new CoffeeResponse<SelectMeasurementUnitCoffeeResponse>(result, "Measurement units retrieved successfully"));
            });
        }
    }
}
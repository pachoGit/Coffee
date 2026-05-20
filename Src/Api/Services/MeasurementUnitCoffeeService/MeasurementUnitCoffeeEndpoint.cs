using Api.Services.MeasurementUnitCoffeeService.SelectMeasurementUnitCoffee;

namespace Api.Services.MeasurementUnitCoffeeService
{
    public static class MeasurementUnitCoffeeEndpoint
    {
        private static RouteGroupBuilder RouteGroup(WebApplication app)
        {
            return app.MapGroup("/api/measurement-unit-coffee");
        }

        public static void Endpoints(WebApplication app)
        {
            var routeGroup = RouteGroup(app);
            SelectMeasurementUnitCoffeeEndpoint.Endpoint(routeGroup);
        }
    }
}
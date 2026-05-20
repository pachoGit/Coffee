using Api.Services.CoffeeVarietyService.SelectCoffeeVariety;

namespace Api.Services.CoffeeVarietyService
{
    public static class CoffeeVarietyEndpoint
    {
        private static RouteGroupBuilder RouteGroup(WebApplication app)
        {
            return app.MapGroup("/api/coffee-variety");
        }

        public static void Endpoints(WebApplication app)
        {
            var routeGroup = RouteGroup(app);
            SelectCoffeeVarietyEndpoint.Endpoint(routeGroup);
        }
    }
}
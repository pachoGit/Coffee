using Api.Services.CoffeeTypeService.SelectCoffeeType;

namespace Api.Services.CoffeeTypeService
{
    public static class CoffeeTypeEndpoint
    {
        private static RouteGroupBuilder RouteGroup(WebApplication app)
        {
            return app.MapGroup("/api/coffee-type");
        }

        public static void Endpoints(WebApplication app)
        {
            var routeGroup = RouteGroup(app);
            SelectCoffeeTypeEndpoint.Endpoint(routeGroup);
        }
    }
}
namespace Api.Services.PurchaseService
{
    public static class CreatePurchaseEndpoint
    {
        private static RouteGroupBuilder RouteGroup(WebApplication app)
        {
            return app.MapGroup("/api/purchase");
        }

        public static void Endpoints(WebApplication app)
        {

        }
    }
}

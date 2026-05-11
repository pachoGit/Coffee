using Api.Services.PurchaseService.CreatePurchase;

namespace Api.Services.PurchaseService
{
    public static class PurchaseServiceEndpoint
    {
        public static void Endpoints(WebApplication app)
        {
            var routeGroup = app.MapGroup("/api/purchase");

            CreatePurchaseEndpoint.Endpoint(routeGroup);
        }
    }
}

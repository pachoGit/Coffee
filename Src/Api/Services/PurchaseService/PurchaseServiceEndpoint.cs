using Api.Services.PurchaseService.CreatePurchase;
using Api.Services.PurchaseService.GetPurchaseById;

namespace Api.Services.PurchaseService
{
    public static class PurchaseServiceEndpoint
    {
        public static void Endpoints(WebApplication app)
        {
            var routeGroup = app.MapGroup("/api/purchase");

            CreatePurchaseEndpoint.Endpoint(routeGroup);
            GetPurchaseByIdEndpoint.Endpoint(routeGroup);
        }
    }
}

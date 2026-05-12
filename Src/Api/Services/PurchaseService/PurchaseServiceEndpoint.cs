using Api.Services.PurchaseService.CreatePurchase;
using Api.Services.PurchaseService.GetPurchaseById;
using Api.Services.PurchaseService.ListPurchase;

namespace Api.Services.PurchaseService
{
    public static class PurchaseServiceEndpoint
    {
        public static void Endpoints(WebApplication app)
        {
            var routeGroup = app.MapGroup("/api/purchase");

            CreatePurchaseEndpoint.Endpoint(routeGroup);
            GetPurchaseByIdEndpoint.Endpoint(routeGroup);
            ListPurchaseEndpoint.Endpoint(routeGroup);
        }
    }
}

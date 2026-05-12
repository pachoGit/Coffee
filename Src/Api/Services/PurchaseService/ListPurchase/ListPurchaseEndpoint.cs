using Microsoft.AspNetCore.Mvc;

namespace Api.Services.PurchaseService.ListPurchase
{
    public static class ListPurchaseEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/list", async ([AsParameters] ListPurchaseRequest request, ListPurchaseHandler? handler) =>
            {
                var response = await handler!.Handle(request);
                return Results.Ok(response);
            });
        }
    }
}

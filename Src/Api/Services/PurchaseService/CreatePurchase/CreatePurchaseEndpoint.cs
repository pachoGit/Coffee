using Microsoft.AspNetCore.Mvc;

namespace Api.Services.PurchaseService.CreatePurchase
{
    public static class CreatePurchaseEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapPost("/", async ([FromBody] CreatePurchaseRequest request, CreatePurchaseHandler handler) =>
            {
                var response = await handler.Handle(request);
                return Results.Created($"/api/purchase/{response.PurchaseId}", response);
            });
        }
    }
}
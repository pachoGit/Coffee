using Api.Services.Common;
using Microsoft.AspNetCore.Mvc;

namespace Api.Services.PurchaseService.UpdatePurchase
{
    public static class UpdatePurchaseEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapPut("/{id:int}", async ([FromRoute] int id, [FromBody] UpdatePurchaseRequest request, UpdatePurchaseHandler handler) =>
            {
                var purchaseId = await handler.Handle(id, request);
                if (purchaseId == null)
                {
                    return Results.NotFound(new CoffeeResponse<UpdatePurchaseResponse>(null!, "Purchase not found"));
                }
                return Results.Ok(new CoffeeResponse<UpdatePurchaseResponse>(new UpdatePurchaseResponse(purchaseId.Value), "Purchase updated successfully"));
            });
        }
    }
}

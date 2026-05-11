using Microsoft.AspNetCore.Mvc;

namespace Api.Services.PurchaseService.GetPurchaseById
{
    public static class GetPurchaseByIdEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/{id:int}", async (int id, GetPurchaseByIdHandler handler) =>
            {
                var response = await handler.Handle(id);
                if (response == null)
                {
                    return Results.NotFound(new { message = "Purchase not found" });
                }
                return Results.Ok(response);
            });
        }
    }
}
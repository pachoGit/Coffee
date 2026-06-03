using Api.Services.Common;

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
                    return Results.NotFound(new CoffeeResponse<GetPurchaseByIdResponse>(null!, "Purchase not found"));
                }
                return Results.Ok(new CoffeeResponse<GetPurchaseByIdResponse>(response, "Purchase retrieved successfully"));
            });
        }
    }
}

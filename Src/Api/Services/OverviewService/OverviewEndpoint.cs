using Api.Services.Common;
using Microsoft.AspNetCore.Mvc;

namespace Api.Services.OverviewService
{
    public static class OverviewEndpoint
    {
        public static void Endpoint(RouteGroupBuilder routeGroup)
        {
            routeGroup.MapGet("/purchase", async ([AsParameters] OverviewRequest request, OverviewHandler handler) =>
            {
                var response = await handler.Handle(request);
                return Results.Ok(new CoffeeResponse<OverviewResponse>(response, "Purchase overview retrieved successfully"));
            });
        }
    }
}

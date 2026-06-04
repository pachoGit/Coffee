namespace Api.Services.OverviewService
{
    public static class OverviewServiceEndpoint
    {
        public static void Endpoints(WebApplication app)
        {
            var routeGroup = app.MapGroup("/api/overview");
            OverviewEndpoint.Endpoint(routeGroup);
        }
    }
}

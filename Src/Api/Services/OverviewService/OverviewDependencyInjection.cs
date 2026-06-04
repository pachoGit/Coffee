namespace Api.Services.OverviewService
{
    public static class OverviewDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<OverviewHandler>();
        }
    }
}

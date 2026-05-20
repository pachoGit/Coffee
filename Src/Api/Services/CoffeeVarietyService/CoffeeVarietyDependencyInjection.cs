using Api.Services.CoffeeVarietyService.SelectCoffeeVariety;

namespace Api.Services.CoffeeVarietyService
{
    public static class CoffeeVarietyDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<SelectCoffeeVarietyHandler>();
        }
    }
}
using Api.Services.CoffeeTypeService.SelectCoffeeType;

namespace Api.Services.CoffeeTypeService
{
    public static class CoffeeTypeDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<SelectCoffeeTypeHandler>();
        }
    }
}
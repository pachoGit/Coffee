using Api.Services.MeasurementUnitCoffeeService.SelectMeasurementUnitCoffee;

namespace Api.Services.MeasurementUnitCoffeeService
{
    public static class MeasurementUnitCoffeeDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<SelectMeasurementUnitCoffeeHandler>();
        }
    }
}
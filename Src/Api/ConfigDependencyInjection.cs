using Api.Services.CoffeeProducerService.CreateCoffeeProducer;
using Api.Services.CoffeeProducerService.ListCoffeeProducer;

namespace Api
{
    public static class ConfigDependecyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<CreateCoffeeProducerHandler>();
            services.AddScoped<ListCoffeeProducerHandler>();
        }
    }
}

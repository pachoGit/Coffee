using Api.Services.CoffeeProducerService.CreateCoffeeProducer;
using Api.Services.CoffeeProducerService.ListCoffeeProducer;
using Api.Services.CoffeeProducerService.GetCoffeeProducerById;
using Api.Services.CoffeeProducerService.UpdateCoffeeProducer;
using Api.Services.CoffeeProducerService.DeleteCoffeeProducer;

namespace Api.Services.CoffeeProducerService
{
    public static class CoffeeProducerDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<CreateCoffeeProducerHandler>();
            services.AddScoped<ListCoffeeProducerHandler>();
            services.AddScoped<GetCoffeeProducerByIdHandler>();
            services.AddScoped<UpdateCoffeeProducerHandler>();
            services.AddScoped<DeleteCoffeeProducerHandler>();
        }
    }
}
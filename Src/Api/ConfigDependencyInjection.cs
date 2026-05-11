using Api.Services.CoffeeProducerService.CreateCoffeeProducer;
using Api.Services.CoffeeProducerService.ListCoffeeProducer;
using Api.Services.CoffeeProducerService.GetCoffeeProducerById;
using Api.Services.CoffeeProducerService.UpdateCoffeeProducer;
using Api.Services.CoffeeProducerService.DeleteCoffeeProducer;
using Api.Services.PurchaseService.CreatePurchase;
using Api.Services.BatchCoffeeProducerService.CreateBatchCoffeeProducer;
using Api.Services.BatchCoffeeProducerService.ListBatchCoffeeProducer;
using Api.Services.BatchCoffeeProducerService.GetBatchCoffeeProducerById;
using Api.Services.BatchCoffeeProducerService.UpdateBatchCoffeeProducer;
using Api.Services.BatchCoffeeProducerService.DeleteBatchCoffeeProducer;

namespace Api
{
    public static class ConfigDependecyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<CreateCoffeeProducerHandler>();
            services.AddScoped<ListCoffeeProducerHandler>();
            services.AddScoped<GetCoffeeProducerByIdHandler>();
            services.AddScoped<UpdateCoffeeProducerHandler>();
            services.AddScoped<DeleteCoffeeProducerHandler>();
            services.AddScoped<CreatePurchaseHandler>();
            services.AddScoped<CreateBatchCoffeeProducerHandler>();
            services.AddScoped<ListBatchCoffeeProducerHandler>();
            services.AddScoped<GetBatchCoffeeProducerByIdHandler>();
            services.AddScoped<UpdateBatchCoffeeProducerHandler>();
            services.AddScoped<DeleteBatchCoffeeProducerHandler>();
        }
    }
}

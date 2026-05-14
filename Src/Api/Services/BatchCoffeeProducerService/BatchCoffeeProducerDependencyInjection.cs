using Api.Services.BatchCoffeeProducerService.CreateBatchCoffeeProducer;
using Api.Services.BatchCoffeeProducerService.ListBatchCoffeeProducer;
using Api.Services.BatchCoffeeProducerService.GetBatchCoffeeProducerById;
using Api.Services.BatchCoffeeProducerService.UpdateBatchCoffeeProducer;
using Api.Services.BatchCoffeeProducerService.DeleteBatchCoffeeProducer;

namespace Api.Services.BatchCoffeeProducerService
{
    public static class BatchCoffeeProducerDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<CreateBatchCoffeeProducerHandler>();
            services.AddScoped<ListBatchCoffeeProducerHandler>();
            services.AddScoped<GetBatchCoffeeProducerByIdHandler>();
            services.AddScoped<UpdateBatchCoffeeProducerHandler>();
            services.AddScoped<DeleteBatchCoffeeProducerHandler>();
        }
    }
}
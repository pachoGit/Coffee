using Api.Services.PurchaseService.CreatePurchase;
using Api.Services.PurchaseService.GetPurchaseById;
using Api.Services.PurchaseService.ListPurchase;

namespace Api.Services.PurchaseService
{
    public static class PurchaseDependencyInjection
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<CreatePurchaseHandler>();
            services.AddScoped<GetPurchaseByIdHandler>();
            services.AddScoped<ListPurchaseHandler>();
        }
    }
}

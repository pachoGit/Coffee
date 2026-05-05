using Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database
{
    public static class CoffeeDbConfiguration
    {
        public static void Config(IServiceCollection services)
        {
            var connectionString = EnvVariables.CoffeeDbConnection;
            services.AddDbContext<CoffeeDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });
        }
    }
}

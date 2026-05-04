using Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database
{
    public static class CoffeeDbConfigure
    {
        public static void Configure(IServiceCollection services)
        {
            var connectionString = EnvVariables.CoffeeDbConnection;
            Console.WriteLine("Conexion a base de datos: " + connectionString);
            services.AddDbContext<CoffeeDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });
        }
    }
}

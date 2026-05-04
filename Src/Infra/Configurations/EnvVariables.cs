namespace Infra.Configurations
{
    public static class EnvVariables
    {
        public static String? CoffeeDbConnection = Environment.GetEnvironmentVariable("DB_CONNECTION");
    }
}

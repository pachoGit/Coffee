namespace Infra.Configurations
{
    public static class ConfigureEnv
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            var environment = builder.Environment.EnvironmentName ?? "Development";

            string envFile = environment switch
                {
                    "Development" => ".env.development",
                    "Staging" => ".env.qa",
                    "Production" => ".env.production",
                    _ => ".env.development"
                };

            if (File.Exists(envFile))
            {
                DotNetEnv.Env.Load(envFile);
            }
        }
    }
}

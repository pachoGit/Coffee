namespace Infra.Configurations
{
    public static class ConfigurationEnv
    {
        public static void Config(WebApplicationBuilder builder)
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

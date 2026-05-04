namespace Infra.Configurations
{
    public class ConfigurationVariables
    {
        private readonly WebApplicationBuilder _builder;

        public String? MaxAVG = null;

        public ConfigurationVariables(WebApplicationBuilder builder)
        {
            _builder = builder;
        }

        public void Load()
        {
            MaxAVG = _builder.Configuration.GetValue<String?>("MaxAVG");
        }
    }
}

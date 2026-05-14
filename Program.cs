using Infra.Configurations;
using Infra.Database;
using Api;

var builder = WebApplication.CreateSlimBuilder(args);

ConfigurationEnv.Config(builder);

CoffeeDbConfiguration.Config(builder.Services);

ConfigDependencyInjection.Config(builder.Services);

var app = builder.Build();

CoffeeEndpointBuilder.Build(app);

var endpoints = app.Services.GetRequiredService<EndpointDataSource>();
foreach (var endpoint in endpoints.Endpoints)
{
    Console.WriteLine(endpoint.DisplayName);
}

app.Run();

using Infra.Configurations;
using Infra.Database;
using Api;

var builder = WebApplication.CreateSlimBuilder(args);

ConfigurationEnv.Config(builder);

CoffeeDbConfiguration.Config(builder.Services);

ConfigDependencyInjection.Config(builder.Services);

builder.Services.AddCors(o => o.AddPolicy("corsApp", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseCors("corsApp");

CoffeeEndpointBuilder.Build(app);

var endpoints = app.Services.GetRequiredService<EndpointDataSource>();
foreach (var endpoint in endpoints.Endpoints)
{
    Console.WriteLine(endpoint.DisplayName);
}

app.Run();

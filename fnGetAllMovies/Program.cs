using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services.AddSingleton(s =>
{
    string? connectionString = Environment.GetEnvironmentVariable("CosmoDBConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new ArgumentNullException(nameof(connectionString), "CosmoDBConnection is not configured.");
    }
    return new CosmosClient(connectionString);
});

builder.Build().Run();

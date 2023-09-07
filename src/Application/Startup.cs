using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service;
using System;

[assembly: FunctionsStartup(typeof(Application.Startup))]

namespace Application
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IGraphService, GraphService>();
            builder.Services.AddScoped<IGraphRepository, GraphyRepository>();

            IConfiguration configuration = new ConfigurationBuilder()
             .SetBasePath(Environment.CurrentDirectory)
             .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
             .AddEnvironmentVariables()
             .Build();

            builder.Services.AddSingleton<IConfiguration>(configuration);

            builder.Services.AddHttpClient();
            builder.Services.AddHttpClient("graph", client =>
            {
                client.BaseAddress = new Uri(configuration["GRAPH_APP_URL"]);
            });
        }

    }
    
}

namespace Monitor.ApiGateway.Web
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;

    public static class ConfigureOcelot
    {
        public static void ConfigureBuilderServices(IWebHostBuilder builder)
        {
            builder.ConfigureServices(s => s.AddSingleton(builder))
                               .ConfigureAppConfiguration(ic => ic.AddJsonFile("routes.json", optional: false, reloadOnChange: true))
                               .UseStartup<Startup>();
        }
    }
}
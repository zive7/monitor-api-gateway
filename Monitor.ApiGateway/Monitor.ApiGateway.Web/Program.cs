namespace Monitor.ApiGateway.Web
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Run();
        }

        public static IWebHost CreateWebHostBuilder(string[] args)
        {
            IWebHostBuilder builder = WebHost.CreateDefaultBuilder(args);

            ConfigureOcelot.ConfigureBuilderServices(builder);
            IWebHost host = builder.Build();

            return host;
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Steeltoe.Extensions.Configuration.ConfigServer;

namespace ConfigServerClient
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .AddConfigServer() //Adds config server as config source
            .ConfigureWebHostDefaults(webBuilder =>
            {
                 webBuilder.UseStartup<Startup>();
            });
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Nito.AsyncEx;
using Serilog;

namespace Api_library
{
    public class Program
    {

        static void Main(string[] args)
        {
            AsyncContext.Run(() => MainAsync(args));
        }


        public static async Task MainAsync(string[] args)
        {
            try
            {
                var host = CreateWebHostBuilder(args).Build();
                await host.RunAsync();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.Warning("Application is shutting down");
                Log.CloseAndFlush();
            }
        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>();
    }
}

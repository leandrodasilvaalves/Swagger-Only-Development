using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;

namespace Swagger_Only_Development
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
             WebHost.CreateDefaultBuilder(args)
                .UseIISIntegration()
                .UseApplicationInsights()
                .UseStartup(Assembly.GetEntryAssembly().FullName)
                .Build();
    }
}

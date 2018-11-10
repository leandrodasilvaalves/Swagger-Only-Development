using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swagger_Only_Development;

namespace SwaggerOnlyDevelopment
{
    public class StartupProduction : Startup
    {
        public StartupProduction(IConfiguration configuration) : base(configuration)
        { }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseExceptionHandler("/Error");
            base.Configure(app, env);
        }
    }
}

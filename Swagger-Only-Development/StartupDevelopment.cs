using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swagger_Only_Development;
using Swashbuckle.AspNetCore.Swagger;

namespace SwaggerOnlyDevelopment
{
    public class StartupDevelopment : Startup
    {
        public StartupDevelopment(IConfiguration configuration) : base(configuration)
        { }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Swagger-Only-Development - Swagger .Net Core", Version = "v1" });
            });
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            base.Configure(app, env);

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Only Development");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}

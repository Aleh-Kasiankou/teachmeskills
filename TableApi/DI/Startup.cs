using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IHomeService, HomeService>();
            services.AddSwaggerDocument(config =>
            {
                config.Title = "Swagger Custom Name";
            }); // add Swagger v2 document
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            
            app.UseOpenApi(); // serve OpenAPI/Swagger documents
            app.UseSwaggerUi3(config =>
            {
                config.DocExpansion = "list";
            });
            // app.UseReDoc(); // serve ReDoc UI
        }
    }
}

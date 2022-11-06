using System;
using System.Text.Json.Serialization;
using API.Entities;
using API.Helpers;
using API.Models;
using API.Services.Formatting;
using API.Services.Repositories;
using API.Services.Validation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataBase>();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            ).AddJsonOptions(x =>
            {
                // serialize enums as strings in api responses (e.g. Role)
                x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                
            });
            
            services.Configure<ConnectionStrings>(Configuration.GetSection(ConnectionStrings.ConfigSection));
            services.AddScoped<IRepository<AttributeEntity>, AttributeRepository>();
            services.AddScoped<IValidator<AttributeEntity>, AttributeEntityValidator>();
            services.AddScoped<IFormatter<ValidationError>, ValidationErrorFormatter>();
            services.AddSwaggerDocument(config => { config.Title = "AttributeAPI"; });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseOpenApi();

            app.UseSwaggerUi3(config => { config.DocExpansion = "list"; });
        }
    }
}
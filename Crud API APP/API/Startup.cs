using API.Helpers.Formatting;
using API.Helpers.Mapping;
using API.Helpers.Validation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;
using RepositoryService;
using RepositoryService.Entities;
using RepositoryService.Repositories;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataBase>();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.Configure<ConnectionStrings>(Configuration.GetSection(ConnectionStrings.ConfigSection));
            services.AddScoped<IRepository<AttributeEntity>, AttributeRepository>();
            services.AddScoped<IRepository<AttributeTypeEntity>, AttributeTypeRepository>();
            services.AddScoped<IRepository<PossibleValueEntity>, PossibleValueRepository>();
            services.AddScoped<IValidator<AttributeModel>, AttributeEntityValidator>();
            services.AddSingleton<IFormatter<ValidationError>, ValidationErrorFormatter>();
            services.AddScoped<IMapper<AttributeModel>, AttributeMapper>();
            services.AddScoped<IMapper<AttributeTypeModel>, AttributeTypeMapper>();
            services.AddScoped<IMapper<PossibleValueModel>, PossibleValueMapper>();
            services.AddSwaggerDocument(config => { config.Title = "AttributeAPI"; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
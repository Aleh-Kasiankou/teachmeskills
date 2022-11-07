using API.Entities;
using API.Services.Formatting;
using API.Services.Repositories;
using API.Services.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace API.Services.DI
{
    public static class DependencyInjector
    {
        public static IServiceCollection ConfigureAttributeServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository<AttributeEntity>, AttributeRepository>();
            services.AddScoped<IValidator<AttributeEntity>, AttributeEntityValidator>();
            services.AddScoped<IFormatter<ValidationError>, ValidationErrorFormatter>();
            return services;
        }
    }
}
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
            services.AddScoped<IRepository<Attribute>, AttributeRepository>();
            services.AddScoped<IValidator<Attribute>, AttributeEntityValidator>();
            services.AddScoped<IFormatter<ValidationErrorException>, ValidationErrorFormatter>();
            return services;
        }
    }
}
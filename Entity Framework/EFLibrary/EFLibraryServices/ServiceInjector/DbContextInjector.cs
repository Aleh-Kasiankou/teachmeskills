using EFLibraryPersistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFLibraryServices.ServiceInjector
{
    public static class DbContextInjector
    {
        public static IServiceCollection InjectEfLibraryDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EfLibraryDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
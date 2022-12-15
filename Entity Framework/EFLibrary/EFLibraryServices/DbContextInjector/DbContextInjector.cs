using EFLibraryPersistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFLibraryServices.DbContextInjector
{
    public static class DbContextInjector
    {
        public static IServiceCollection ConfigureDbContextDi(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EfLibraryDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
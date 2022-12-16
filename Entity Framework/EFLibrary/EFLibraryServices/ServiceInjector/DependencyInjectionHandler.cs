using Microsoft.Extensions.DependencyInjection;

namespace EFLibraryServices.ServiceInjector
{
    public static class DependencyInjectionHandler
    {
        public static IServiceCollection InjectEfLibraryServices(this IServiceCollection services)
        {
            services.AddScoped<DbSampleDataGenerator.DbSampleDataGenerator>();
            services.AddScoped<BorrowedBookTracker.BorrowedBookTracker>();
            services.AddScoped<DbCleaner.DbCleaner>();
            services.AddScoped<BookReturnHandler.BookReturnHandler>();
            return services;
        }
    }
}
using InteractiveTable;
using Io;
using Microsoft.Extensions.DependencyInjection;
using TableApi.TableWebSupport;

namespace TableApi
{
    public static class DiExtensions{
    
        public static IServiceCollection ConfigurePersonManagementServices (this IServiceCollection services){
        services.AddSingleton<IImportHandler<Person>, ImportManager<Person>>();
        services.AddSingleton<ITableBuilder<Person>, TableBuilder<Person>>();
        services.AddSingleton<IDataPathProvider, WebDataPathProvider>();
        
        return services;
    }

    }

}
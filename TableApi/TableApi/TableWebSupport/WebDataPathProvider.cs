using Io;
using Microsoft.Extensions.Configuration;

namespace TableApi.TableWebSupport
{
    public class WebDataPathProvider : IDataPathProvider
    {
        public string Path { get; set; }
        
        public WebDataPathProvider(IConfiguration config)
        {
            Path = config.GetValue<string>("DataFilePath");
        }
        
    }
}
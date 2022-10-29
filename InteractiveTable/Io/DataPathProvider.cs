using System;

namespace Io
{
    public class DataPathProvider : IDataPathProvider
    {
        public string Path { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "samplePersonList.json";
    }
}
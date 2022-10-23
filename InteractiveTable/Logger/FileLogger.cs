using System;
using System.IO;
using System.Text;

namespace Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string message, LogLevel logLevel)
        {
            Stream stream = null;
            try
            {
                stream = File.Open("log.txt", FileMode.Append);
                TextWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
                streamWriter.Write($"{logLevel.ToString()} - {DateTime.UtcNow} -- {message}\n");
                streamWriter.Flush();
            }
            finally
            {
                stream?.Dispose();
            }
        }
    }
}
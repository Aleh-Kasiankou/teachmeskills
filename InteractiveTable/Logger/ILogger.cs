namespace Logger
{
    public interface ILogger
    {
        public void Log(string message, LogLevel loglevel);
    }
}
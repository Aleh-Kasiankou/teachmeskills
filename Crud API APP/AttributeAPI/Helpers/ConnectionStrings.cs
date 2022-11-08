using System;

namespace API.Helpers
{
    public class ConnectionStrings
    {
        public const string ConfigSection = "ConnectionStrings";
        public string Default { get; set; } = String.Empty;
    }
}
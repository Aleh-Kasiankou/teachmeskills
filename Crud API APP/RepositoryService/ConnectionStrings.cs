using System;

namespace RepositoryService
{
    public class ConnectionStrings
    {
        public const string ConfigSection = "ConnectionStrings";
        public string Default { get; set; } = String.Empty;
    }
}
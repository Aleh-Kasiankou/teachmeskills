using System.Collections.Generic;

namespace API.Services.Formatting
{
    public interface IFormatter<T>
    {
        public string Format(IEnumerable<T> objList);
    }
}
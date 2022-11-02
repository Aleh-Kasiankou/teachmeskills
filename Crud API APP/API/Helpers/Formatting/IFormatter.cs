using System.Collections.Generic;

namespace API.Helpers.Formatting
{
    public interface IFormatter<T>
    {
        public string Format(IEnumerable<T> objList);
    }
}
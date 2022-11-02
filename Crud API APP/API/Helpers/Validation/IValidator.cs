using System.Collections.Generic;

namespace API.Helpers.Validation
{
    public interface IValidator<T>
    {
        public List<ValidationError> ValidationErrors { get; }
        (bool IsValid, string formattedExceptionList) Validate(T entity);
    }
}
using System.Collections.Generic;

namespace API.Services.Validation
{
    public interface IValidator<T>
    {
        List<ValidationError> ValidationErrors { get; }
        void Validate(T entity);
    }
}
using System.Collections.Generic;

namespace API.Services.Validation
{
    public interface IValidator<T>
    {
        List<ValidationErrorException> ValidationErrors { get; }
        void Validate(T entity);
    }
}
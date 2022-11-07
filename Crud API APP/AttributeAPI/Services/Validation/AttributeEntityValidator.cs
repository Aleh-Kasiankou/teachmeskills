using System.Collections.Generic;
using API.Entities;
using API.Models;
using API.Services.Formatting;

namespace API.Services.Validation
{
    public class AttributeEntityValidator : IValidator<AttributeEntity>
    {
        private IFormatter<ValidationError> _formatter;
        
        public AttributeEntityValidator(IFormatter<ValidationError> formatter)
        {
            _formatter = formatter;
        }

        public List<ValidationError> ValidationErrors { get; } = new List<ValidationError>();
        
        public (bool IsValid, string formattedExceptionList) Validate(AttributeEntity entity)
        {
            return ValidationErrors.Count == 0 ? (true, "") : (false, _formatter.Format(ValidationErrors));
        }

        private void CheckIsUnderPosted(AttributeEntity entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Name))
            {
                ValidationErrors.Add(new NoNameProvidedError());
            }
        }


        private void CheckIsOverPosted(AttributeEntity entity)
        {
            {
                // TODO add constants with available type names and check whether parameters are used by the attribute type.
            }
        }
    }
}
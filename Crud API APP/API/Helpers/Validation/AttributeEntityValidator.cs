using System.Collections.Generic;
using API.Helpers.Formatting;
using Models;

namespace API.Helpers.Validation
{
    public class AttributeEntityValidator : IValidator<AttributeModel>
    {
        public AttributeEntityValidator(IFormatter<ValidationError> formatter)
        {
            _formatter = formatter;
        }

        public List<ValidationError> ValidationErrors { get; } = new List<ValidationError>();
        private IFormatter<ValidationError> _formatter;

        public (bool IsValid, string formattedExceptionList) Validate(AttributeModel entity)
        {
            return ValidationErrors.Count == 0 ? (true, "") : (false, _formatter.Format(ValidationErrors));
        }

        private void CheckIsUnderPosted(AttributeModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name))
            {
                ValidationErrors.Add(new NoNameProvidedError());
            }
        }


        private void CheckIsOverPosted(AttributeModel model)
        {
            {
                // TODO add constants with available type names and check whether parameters are used by the attribute type.
            }
        }
    }
}
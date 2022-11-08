using System.Collections.Generic;
using API.Entities;
using API.Services.Formatting;

namespace API.Services.Validation
{
    public class AttributeEntityValidator : IValidator<Attribute>
    {
        private IFormatter<ValidationErrorException> _formatter;

        public AttributeEntityValidator(IFormatter<ValidationErrorException> formatter)
        {
            _formatter = formatter;
        }

        public List<ValidationErrorException> ValidationErrors { get; } = new List<ValidationErrorException>();

        public void Validate(Attribute entity)
        {
            CheckNonSelectableData(entity);
            CheckSelectableData(entity);
            CheckMeasurementUnit(entity);
            if (ValidationErrors.Count > 0)
            {
                throw new ValidationErrorException(_formatter.Format(ValidationErrors));
            }
        }


        private void CheckNonSelectableData(Attribute entity)
        {
            {
                if (entity.AttributeType == AttributeType.Numeric || entity.AttributeType == AttributeType.Price ||
                    entity.AttributeType == AttributeType.Text)
                {
                    if (entity.PossibleValues != null)
                    {
                        ValidationErrors.Add(
                            new WrongTypeParameterProvided("Non-selectable attribute cannot have options"));
                    }
                }
            }
        }

        private void CheckSelectableData(Attribute entity)
        {
            if (entity.AttributeType == AttributeType.MultipleSelect ||
                entity.AttributeType == AttributeType.SingleSelect || entity.AttributeType == AttributeType.YesNo)
            {
                if (entity.DefaultLiteralValue != null)
                {
                    ValidationErrors.Add(
                        new WrongTypeParameterProvided("Selectable attributes cannot have default literal value"));
                }
            }
        }

        private void CheckMeasurementUnit(Attribute entity)
        {
            if (entity.AttributeType != AttributeType.Numeric && entity.MeasurementUnit != null)
            {
                ValidationErrors.Add(
                    new WrongTypeParameterProvided("Only numeric attributes can have measurement unit"));
            }
        }
        
        private void CheckYesNoAttribute() {
            
        }
    }
}
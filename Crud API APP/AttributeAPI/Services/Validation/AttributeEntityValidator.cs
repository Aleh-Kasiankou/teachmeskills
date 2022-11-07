using System.Collections.Generic;
using API.Entities;
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

        public void Validate(AttributeEntity entity)
        {
            CheckNonSelectableData(entity);
            CheckSelectableData(entity);
            CheckMeasurementUnit(entity);
            if (ValidationErrors.Count > 0)
            {
                throw new ValidationError(_formatter.Format(ValidationErrors));
            }
        }


        private void CheckNonSelectableData(AttributeEntity entity)
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

        private void CheckSelectableData(AttributeEntity entity)
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

        private void CheckMeasurementUnit(AttributeEntity entity)
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
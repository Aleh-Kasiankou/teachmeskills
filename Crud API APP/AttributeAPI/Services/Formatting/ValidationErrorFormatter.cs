using System.Collections.Generic;
using System.Text;
using API.Services.Validation;

namespace API.Services.Formatting
{
    public class ValidationErrorFormatter : IFormatter<ValidationError>
    {
        public string Format(IEnumerable<ValidationError> objList)
        {
            var formattedString = new StringBuilder();
            
            foreach (var error in objList)
            {
                formattedString.Append(error.Message + "\n");
            }

            return formattedString.ToString();
        }
    }
}
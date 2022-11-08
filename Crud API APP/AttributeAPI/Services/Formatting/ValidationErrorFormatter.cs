using System.Collections.Generic;
using System.Text;
using API.Services.Validation;

namespace API.Services.Formatting
{
    public class ValidationErrorFormatter : IFormatter<ValidationErrorException>
    {
        public string Format(IEnumerable<ValidationErrorException> objList)
        {
            var formattedString = new StringBuilder();
            
            foreach (var error in objList)
            {
                formattedString.AppendLine(error.Message);
            }

            return formattedString.ToString();
        }
    }
}
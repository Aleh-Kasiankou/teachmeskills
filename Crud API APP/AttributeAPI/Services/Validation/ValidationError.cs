using System;

namespace API.Services.Validation
{
    public class ValidationErrorException : Exception
    {
        public ValidationErrorException()
        {
        }

        public ValidationErrorException(string message) : base(message)
        {
            
        }
    }
    
    public class WrongTypeParameterProvided : ValidationErrorException
    {
        public WrongTypeParameterProvided(string message )
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
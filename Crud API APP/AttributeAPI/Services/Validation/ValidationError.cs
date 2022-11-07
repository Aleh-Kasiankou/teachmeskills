using System;

namespace API.Services.Validation
{
    public class ValidationError : Exception
    {
        public ValidationError()
        {
        }

        public ValidationError(string message) : base(message)
        {
            
        }
    }
    
    public class WrongTypeParameterProvided : ValidationError
    {
        public WrongTypeParameterProvided(string message )
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
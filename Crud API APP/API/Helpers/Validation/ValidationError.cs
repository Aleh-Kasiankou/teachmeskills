using System;

namespace API.Helpers.Validation
{
    public abstract class ValidationError : Exception
    {
    }

    public class NoNameProvidedError : ValidationError
    {
        private const string Msg = "Attribute must have a name";
        public override string Message { get; } = Msg;
    }

    public class InvalidTypeProvidedError : ValidationError
    {
        public InvalidTypeProvidedError(string type)
        {
            Message = $"{type} is not a valid Type name";
        }
        
        public override string Message { get; }
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
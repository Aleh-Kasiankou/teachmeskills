using System;

namespace CalculatorApp.Operations
{
    public class OperationManager
    {
        public IOperation Operation { get; set; }

        public OperationManager(decimal operand1, decimal operand2, string operationString)
        {
            Operation = ResolveOperation(operand1, operand2, operationString);
        }

        private IOperation ResolveOperation(decimal operand1, decimal operand2, string sign)
        {
            IOperation operation;
            switch (sign)
            {
                case "+":
                    operation = new Addition(operand1, operand2);
                    break;
                    
                case "-":
                    operation = new Subtraction(operand1, operand2);
                    break;
                default:
                    //create special exceptions for the calculator app
                    throw new Exception(message: $"Sorry, It seems the \"{sign}\" operation is not supported");
            }

            return operation;
        }
    }
    
}
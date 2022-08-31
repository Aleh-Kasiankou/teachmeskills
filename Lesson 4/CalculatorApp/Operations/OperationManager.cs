using System;

namespace CalculatorApp.Operations
{
    public class OperationManager
    {
        public IOperation Operation { get; set; }

        public OperationManager(double operand1, double operand2, string operationString)
        {
            Operation = ResolveOperation(operand1, operand2, operationString);
        }

        private IOperation ResolveOperation(double operand1, double operand2, string sign) //possible to loose coupling?
        {
            IOperation operation = null;
            
            switch (sign)
            {
                case "+":
                    operation = new Addition(operand1, operand2);
                    break;
                    
                case "-":
                    operation = new Subtraction(operand1, operand2);
                    break;
                
                case "/":
                    operation = new Division(operand1, operand2);
                    break;
                
                case "*":
                    operation = new Multiplication(operand1, operand2);
                    break;
                
                case "mod":
                    operation = new Modulo(operand1, operand2);
                    break;
                
                case "pow":
                    operation = new Power(operand1, operand2);
                    break;
                
                case "%":
                    operation = new Percentage(operand1, operand2);
                    break;
                
                case "root":
                    operation = new Root(operand1, operand2);
                    break;

                default:
                    //create special exceptions for the calculator app
                    var exception = new Exception(message: $"Sorry, It seems the operation \"{sign}\" is not supported");
                    Console.WriteLine(exception.Message);
                    break;
            }
        
        return operation;
        }
    }
    
}
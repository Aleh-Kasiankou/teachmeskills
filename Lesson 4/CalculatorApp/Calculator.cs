using System;
using CalculatorApp.Operations;

namespace CalculatorApp
{
    public static class Calculator
    {
        private static bool IsContinue { get; set; } = false; //flag to control loop
        
        public static void Run()
        {
            do
            {
                // move to separate methods of TerminalHandler class
                // add validation and use TryParse
                Console.WriteLine("Please, type your first operand");
                var operand1 = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine("Please, type your second operand");
                var operand2 = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine("Please, type your operation");
                var operationString = Console.ReadLine();

                OperationManager operationHandler = new OperationManager(operand1, operand2, operationString);
                var result = operationHandler.Operation.Execute().ToString();

                Console.WriteLine($"The output equals {result}");
                Console.WriteLine("Conduct another operation?");
                IsContinue = Console.ReadLine() == "Yes";


            } while (IsContinue);
        }

        // private static IOperation ManageUserInput(ref bool isContinue) //Collect Input And Validate
        // {
        //     return new Operation()  ;//resolve operation
        // }

        private static decimal CalculateOperation()
        {
            return 0m;
        }

        private static string FormatMessage()
        {
            return "";
        }
        
    }
}
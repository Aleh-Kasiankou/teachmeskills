using System;
using CalculatorApp.Operations;

namespace CalculatorApp
{
    public static class Calculator
    {
        private static bool IsContinue = false; //flag to control loop
        
        public static void Run()
        {
            do
            {
                TerminalHandler ui = new TerminalHandler(); //initializing UI
                ui.SetOperands();
                ui.SetOperation();
                //selecting operation
                OperationManager operationHandler = new OperationManager(ui.Operand1, ui.Operand2, ui.Operation);
                try
                {
                    Console.WriteLine($"\n{ui.Operand1.ToString()} {ui.Operation} {ui.Operand2.ToString()} == " +
                                      $"{operationHandler.Operation.Execute().ToString()}");
                }

                catch (Exception e)
                {
                    Console.WriteLine($"Sorry, the operation is forbidden: {e.Message}");
                }

                ui.PromptContinue(ref IsContinue);
                


            } while (IsContinue);
        }
    }
}
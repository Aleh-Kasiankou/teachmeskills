using System;
using CalculatorApp.Operations;

namespace CalculatorApp
{
    public static class Calculator
    {
        private static bool _isContinue = false; //flag to control loop
        
        public static void Run()
        {
            do
            {
                UserInterface ui = new UserInterface(); //initializing UI
                ui.SetOperands();
                ui.SetOperation();
                
                OperationManager operationHandler = new OperationManager(ui.Operand1, ui.Operand2, ui.Operation);
                try
                {
                    var result = operationHandler.Operation.Execute();
                    ui.DisplayResult(result, ref ui);
                }
                catch (Exception e)
                {
                    ui.DisplayException(e);
                }
                
                ui.PromptContinue(ref _isContinue);
                

            } while (_isContinue);
        }
    }
}
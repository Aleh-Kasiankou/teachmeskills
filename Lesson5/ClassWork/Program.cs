using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsContinue = true; //false
            do
            {
                try
                {
                    bool isComplete = false;
                    string validNotChunkedExpression = "";
                    var rawExpression = "";
                    var expressionBase = "";
                    
                    while (!isComplete)
                    {
                        rawExpression = TerminalManager.GetExpression();
                        string newExpressionBase;
                        validNotChunkedExpression =
                            ExpressionParser.ValidateExpression(rawExpression, out newExpressionBase, ref isComplete, expressionBase);
                        expressionBase = String.IsNullOrEmpty(newExpressionBase) ? "" : newExpressionBase;

                    }

                    var total = Calculator.Calculate(validNotChunkedExpression);
                    Console.WriteLine(validNotChunkedExpression + " = " + total);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                // finally{TerminalManager.AskIsContinue(ref IsContinue);}
            } while (IsContinue);
        }
    }
}
using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsContinue = true;
            do
            {
                try
                {
                    var rawExpression = TerminalManager.GetExpression();
                    var validNotChunkedExpression = ExpressionParser.ValidateExpression(rawExpression);
                    var total = Calculator.Calculate(validNotChunkedExpression);
                    Console.WriteLine(rawExpression + " = " + total.ToString());
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
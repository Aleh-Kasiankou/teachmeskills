using System;

namespace ClassWork
{
    public static class TerminalManager
    {
        public static double GetOperand()
        {
            Console.WriteLine("Please, type your operand!");
            var operand = Double.Parse(Console.ReadLine());
            return operand;
        }

        public static string GetOperation()
        {
            Console.WriteLine("Please, select your operation!");
            var sign = Console.ReadLine();
            return sign;
        }

        public static void DisplayException(Exception e)
        {
            Console.WriteLine($"Sorry, the input is incorrect: {e.Message}");
        }

        public static void AskIsContinue(ref bool isContinue)
        {
            Console.WriteLine("Conduct another operation? Type Yes to continue");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes" || answer.ToLower() == "y")
            {
                isContinue = true;
            }
        }

        public static void DisplayResult(double result)
        {
            Console.WriteLine($"The result of your operation is {result.ToString()}");
        }
    }
}
using System;

namespace Calculator
{
    public static class TerminalManager
    {
        public static string GetExpression(string oldExpression = "")
        {
            bool isComplete = false;
            bool isInjectedOldExpression = !string.IsNullOrWhiteSpace(oldExpression);
            string validNotChunkedExpression = "";
            var rawExpression = "";
            var expressionBase = "";

            Console.WriteLine("Please, type your expression. To end it, put the equality sign '='");

            while (!isComplete)
            {
                if (!string.IsNullOrWhiteSpace(oldExpression) && isInjectedOldExpression)
                {
                    rawExpression = oldExpression.Trim('=');
                    isInjectedOldExpression = false;
                }

                else
                {
                    rawExpression = GetUserInput(String.Empty);
                }

                validNotChunkedExpression =
                    Validator.ValidateExpression(rawExpression, out var newExpressionBase, ref isComplete,
                        expressionBase);
                expressionBase = String.IsNullOrEmpty(newExpressionBase) ? "" : newExpressionBase;
            }

            return validNotChunkedExpression;
        }

        private static string GetUserInput(string label = "expression")
        {
            if (!string.IsNullOrWhiteSpace(label))
            {
                Console.WriteLine($"Please, type your {label}");
            }

            return Console.ReadLine();
        }

        public static void DisplayException(Exception e)
        {
            Console.WriteLine($"Sorry, the input is incorrect: {e.Message}");
        }

        public static void AskIsContinue(ref bool isContinue, ref bool isSelectedMemoryOperation)
        {
            Console.WriteLine("Conduct another operation? Type 'Yes' to continue with expression calculation and" +
                              " 'M' to work with memory");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes" || answer.ToLower() == "y")
            {
                isContinue = true;
                isSelectedMemoryOperation = false;
            }
            else if (answer.ToLower() == "m")
            {
                isContinue = true;
                isSelectedMemoryOperation = true;
            }
            else
            {
                isContinue = false;
            }
        }

        public static void DisplayResult(string expression, double total)
        {
            Console.WriteLine(expression + " = " + total);
        }

        public static string UpdateExpressionFromMemory(out int memoryId)
        {
            Console.WriteLine("The following expressions are available for editing/replacement:");
            for (int i = 1; i <= Calculator.Memory.Count; i++)
            {
                Console.WriteLine($"{i} {Calculator.Memory[i - 1][0]} = {Calculator.Memory[i - 1][1]} ");
            }

            int id = -1;
            bool isAssigned = false;
            string expression = "";

            while (!isAssigned)
            {
                try
                {
                    Console.WriteLine("What expression would you like to edit? Please type id (0 to leave)");
                    id = Int32.Parse(Console.ReadLine());
                    if (id == 0)
                    {
                        isAssigned = true;
                    }

                    else
                    {
                        if (id >= 1 && id <= Calculator.Memory.Count)
                        {
                            expression = Calculator.Memory[id - 1][0];
                            isAssigned = true;
                        }

                        else
                        {
                            throw new Exception(message: $"{id} is a wrong id, please try again");
                        }
                    }
                }
                catch (Exception e)
                {
                    DisplayException(e);
                }
            }

            memoryId = id - 1;

            if (!string.IsNullOrWhiteSpace(expression))
            {
                string userInput = "";
                while (userInput.Trim().ToLower() != "a" && userInput.Trim().ToLower() != "r")
                {
                    Console.WriteLine("Would you like to Append the expression or Replace it? Please type 'a' or 'r'");
                    userInput = GetUserInput("choice");
                }

                if (userInput.Trim().ToLower() == "a")
                {
                    return GetExpression(expression);
                }

                else
                {
                    return GetExpression();
                }
            }

            return string.Empty;
        }
    }
}
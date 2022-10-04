using System;
using System.Collections.Generic;

namespace ShapePrinter.Services
{
    public static class ConsoleHandler
    {
        public static string HandleUserInput()
        {
            var userInitialInput = Console.ReadKey();
            if (userInitialInput.Key == ConsoleKey.Q)
            {
                UiHandler.StopProgram();
            }

            var userFurtherInput = Console.ReadLine();
            var userJoinedInput = userInitialInput.KeyChar + userFurtherInput;
            return userJoinedInput;
        }

        public static ConsoleKeyInfo HandleUserKeyPress()
        {
            var userInitialInput = Console.ReadKey();
            if (userInitialInput.Key == ConsoleKey.Q)
            {
                UiHandler.StopProgram();
            }

            return userInitialInput;
        }

        public static void OutputData(string data, bool addNewLine = true)
        {
            var optionalNewLine = addNewLine ? "\n" : "";
            Console.Write(data + optionalNewLine);
        }

        public static void OutputPrintingScheme(string textScheme, List<ConsoleColor> colorScheme)
        {
            Console.Clear();
            var colorIndex = 0;

            ConsoleColor systemConsoleColor = Console.ForegroundColor;

            foreach (var symbol in textScheme)
            {
                if (!char.IsWhiteSpace(symbol))
                {
                    Console.ForegroundColor = colorScheme[colorIndex];
                    colorIndex++;
                }

                Console.Write(symbol);
            }

            Console.ForegroundColor = systemConsoleColor;
        }
    }
}
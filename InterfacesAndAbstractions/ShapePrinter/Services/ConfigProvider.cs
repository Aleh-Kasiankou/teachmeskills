using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ShapePrinter
{
    public static class ConfigProvider
    {
        public static Action<string, List<ConsoleColor>> GetOutputMethod()
        {
            OutputMethod userSelectedMethod = UiHandler.PromptForOutputMethod();

            Action<String, List<ConsoleColor>> outputMethod;

            if (userSelectedMethod is OutputMethod.Console)
            {
                outputMethod = (textScheme, colorScheme) =>
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
                    }

                    Console.Write(textScheme);
                    Console.ForegroundColor = systemConsoleColor;
                };
            }
            else
            {
                outputMethod = (textScheme, colorScheme) =>
                {
                    var path = AppDomain.CurrentDomain.BaseDirectory + "shapes.txt";

                    File.WriteAllText(path, textScheme);
                };
            }

            return outputMethod;
        }
    }
}
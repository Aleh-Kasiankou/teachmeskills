using System;
using System.Collections.Generic;
using System.Linq;
using ShapePrinter.Data;

namespace ShapePrinter.Services
{
    public static class UiHandler
    {
        private static readonly List<Type> PrintableTypes = AssemblyLoader.GetPrintableTypes();

        public static readonly Action<String, List<ConsoleColor>> OutputMethod = DependencyInjector.GetOutputMethod();

        public static void RunDialog()
        {
            StartUiPrintableConstructor();
            Printer.Print(OutputMethod);
            AskStopProgram(DependencyInjector.GetContinueProgramAction());
        }

        internal static void StartUiPrintableConstructor()
        {
            var printableType = PrintableTypes[GetPrintableObjId()];
            var objToPrint = PrintableFactory.CreatePrintableObject(printableType);

            var printingScheme = objToPrint.GetPrintingScheme();
            printingScheme = PrintHelper.ConvertToPositiveCoordinates(printingScheme);
            printingScheme = PrintHelper.MoveStartingPoint(printingScheme);
            printingScheme = PrintHelper.SetColor(printingScheme, objToPrint.GetType());
            Printer.AddToQueue(printingScheme);
            AskAddAnotherShape(DependencyInjector.GetAddShapeAction());
        }

        internal static char GetPrintingChar()
        {
            Console.WriteLine("Please specify the char used for the figure");
            bool isValid = false;
            char printingChar = '*';

            while (!isValid)
            {
                var text = Console.ReadLine().ToCharArray();

                isValid = text.Length == 1;
                printingChar = text[0];

                if (!isValid)
                {
                    Console.WriteLine("Please type 1 character");
                }
            }

            return printingChar;
        }

        private static int GetPrintableObjId()
        {
            Console.Clear();
            for (int i = 1; i <= PrintableTypes.Count(); i++)
            {
                Console.WriteLine($"{i} {PrintableTypes[i - 1].Name}");
            }

            bool isValid = false;
            int index = 0;

            Console.WriteLine("Please, select a printable entity");
            while (!isValid)
            {
                isValid = Int32.TryParse(Console.ReadLine(), out var number);
                if (isValid && number >= 1 && number <= PrintableTypes.Count)
                {
                    index = number - 1;
                }

                else
                {
                    Console.WriteLine("Incorrect Id");
                    isValid = false;
                }
            }

            return index;
        }

        internal static OutputMethod PromptForOutputMethod()
        {
            Console.WriteLine("Please select the preferable method of output");

            var outputMethods =
                Enum.GetValues(typeof(OutputMethod));
            string displayMsg = "";
            foreach (var method in outputMethods)
            {
                displayMsg += $"{(int)method} {method}\n";
            }

            Console.WriteLine(displayMsg);

            var userSelectedMethod = (OutputMethod)int.Parse(Console.ReadLine());

            return userSelectedMethod;
        }

        internal static string GetText()
        {
            Console.WriteLine("Please specify the text");
            bool isValid = false;
            var text = "";

            while (!isValid)
            {
                text = Console.ReadLine();
                isValid = !String.IsNullOrWhiteSpace(text);

                if (!isValid)
                {
                    Console.WriteLine("Empty text is not allowed");
                }
            }

            return text;
        }

        internal static int GetSize()
        {
            bool isValid = false;
            Console.WriteLine("Please, select size");
            int size = 10;
            while (!isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out size);
                if (size < 5)
                {
                    Console.WriteLine("Please select size > 5");
                    isValid = false;
                }
            }

            return size;
        }


        internal static CoordinatesPoint GetStartingPoint()
        {
            bool isValid = false;
            Console.WriteLine("Please, select starting point in format 'x , y'");
            int x = 1;
            int y = 1;
            while (!isValid)
            {
                var coordinates = Console.ReadLine().Split(',');
                if (coordinates.Length == 2)
                {
                    isValid = int.TryParse(coordinates[0], out x);
                    if (isValid)
                    {
                        isValid = int.TryParse(coordinates[1], out y);
                        if (isValid)
                        {
                            isValid = x > 0 && y > 0;
                            continue;
                        }
                    }
                }

                Console.WriteLine("The incorrect input");
            }

            return new CoordinatesPoint(x - 1, y - 1);
        }

        private static void AskStopProgram(Action continueProgram)
        {
            Console.WriteLine("\nDraw a new picture? 'Y' to continue");
            if (Console.ReadKey().Key is ConsoleKey.Y)
            {
                continueProgram();
            }
        }

        private static void AskAddAnotherShape(Action addAnotherShape)
        {
            while (true)
            {
                Console.WriteLine("\nAdd another object to Printer queue? Y/N");
                var userKey = Console.ReadKey().Key;
                if (userKey is ConsoleKey.Y)
                {
                    addAnotherShape();
                    break;
                }

                if (userKey is ConsoleKey.N)
                {
                    break;
                }
            }
        }
    }
}
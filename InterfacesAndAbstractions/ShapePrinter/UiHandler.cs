using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapePrinter
{
    public static class UiHandler
    {
        private static Type _type = typeof(IPrintable);

        private static List<Type> _types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => _type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract).ToList();

        public static void Run()
        {
            bool isContinue = true;
            while (isContinue)
            {
                bool isInputFinished = false;
                IPrintable objToPrint;

                while (!isInputFinished)
                {
                    var printableType = _types[GetFigureId()];
                    if (printableType == typeof(PrintableText))
                    {
                        var text = GetText();
                        objToPrint =
                            (IPrintable)Activator.CreateInstance(printableType, new object[] { text});
                    }
                    else
                    {
                        var printableChar = GetPrintingChar();
                        var size = GetSize();
                        objToPrint =
                            (IPrintable)Activator.CreateInstance(printableType, new object[] { size, printableChar });
                    }

                    var scheme = objToPrint.GetPrintingScheme();
                    scheme = Printer.AdaptForPrinting(scheme);

                    var startingPoint = GetStartingPoint();
                    for (int i = 0; i < scheme.Count; i++)
                    {
                        var x = scheme[i].Item1 + startingPoint.Item1;
                        var y = scheme[i].Item2 + startingPoint.Item2;
                        var character = scheme[i].Item3;
                        scheme[i] = (x, y, character);
                    }

                    Printer.AddToQueue(scheme);

                    Console.WriteLine("Continue? Press 'd' to draw the picture");
                    var key = Console.ReadKey().Key;
                    isInputFinished = key is ConsoleKey.D;
                }

                Printer.Print();
                isContinue = AskIsContinue();
                Printer.ClearQueue();
            }
        }

        private static char GetPrintingChar()
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

        private static int GetFigureId()
        {
            Console.Clear();
            for (int i = 1; i <= _types.Count(); i++)
            {
                Console.WriteLine($"{i} {_types[i - 1].Name}");
            }

            bool isValid = false;
            int index = 0;

            Console.WriteLine("Please, select a printable entity");
            while (!isValid)
            {
                isValid = Int32.TryParse(Console.ReadLine(), out var number);
                if (isValid && number >= 1 && number <= _types.Count)
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

        private static string GetText()
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

        private static int GetSize()
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


        private static (int, int) GetStartingPoint()
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

            return (x - 1, y - 1);
        }

        private static bool AskIsContinue()
        {
            Console.WriteLine("\nDraw a new picture? 'Y' to continue");
            return Console.ReadKey().Key is ConsoleKey.Y;
        }
    }
}
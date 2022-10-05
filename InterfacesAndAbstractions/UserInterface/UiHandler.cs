#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using Printer;
using ShapeCreator;
using ShapeCreator.Objects;
using SharedAssets;

namespace UserInterface
{
    public static class UiHandler
    {
        private static readonly List<Type> PrintableTypes = AssemblyLoader.GetPrintableTypes();

        private static Action<String, List<ConsoleColor>> DisplayShape { get; } =
            DependencyInjector.GetShapeOutputMethod();

        private static Action<String, bool> DisplayUi { get; } =
            DependencyInjector.GetUiOutputMethod();

        private static Func<string> PromptUser { get; } =
            DependencyInjector.GetUiInputMethod();

        public static Func<ConsoleKeyInfo>? DetectKeyPress;

        public static void Initialize()
        {
            StartUiPrintableConstructor();
            Printer.Printer.Print(DisplayShape);
            AskStopProgram(DependencyInjector.GetContinueProgramAction());
        }

        internal static void StartUiPrintableConstructor()
        {
            var printableType = PrintableTypes[GetPrintableObjId()];
            var printableArgs = CollectArgsForPrintableObj(printableType);
            var objToPrint = PrintableFactory.CreatePrintableObject(printableType, printableArgs);

            var printingScheme = objToPrint.GetPrintingScheme();
            printingScheme = PrintHelper.ConvertToPositiveCoordinates(printingScheme);
            var startingPoint = GetStartingPoint();
            printingScheme = PrintHelper.MoveStartingPoint(printingScheme, startingPoint);
            printingScheme = PrintHelper.SetColor(printingScheme, objToPrint.GetType());
            Printer.Printer.AddToQueue(printingScheme);
            AskAddAnotherShape(DependencyInjector.GetAddShapeAction());
        }

        public static char GetPrintingChar()
        {
            DisplayUi("Please specify the char used for printing", true);
            bool isValid = false;
            char printingChar = '*';

            while (!isValid)
            {
                var text = PromptUser()?.ToCharArray();

                isValid = text?.Length == 1;
                if (text != null) printingChar = text[0];

                if (!isValid)
                {
                    DisplayUi("Please type 1 character", true);
                }
            }

            return printingChar;
        }

        private static int GetPrintableObjId()
        {
            Console.Clear();
            for (int i = 1; i <= PrintableTypes.Count(); i++)
            {
                DisplayUi($"{i} {PrintableTypes[i - 1].Name}", true);
            }

            bool isValid = false;
            int index = 0;

            DisplayUi("Please, select a printable entity or press Q to stop program", true);
            while (!isValid)
            {
                var userInput = PromptUser();

                isValid = Int32.TryParse(userInput, out var number);
                if (isValid && number >= 1 && number <= PrintableTypes.Count)
                {
                    index = number - 1;
                }

                else
                {
                    DisplayUi("Incorrect Id", true);
                    isValid = false;
                }
            }

            return index;
        }

        internal static OutputMethod PromptForOutputMethod()
        {
            int userSelectedMethod = 1;
            bool isValidInput = false;
            while (!isValidInput)
            {
                ConsoleHandler.OutputData("Please select the preferable method of output"); 
                //console to avoid null reference

                var outputMethods =
                    Enum.GetValues(typeof(OutputMethod));
                string displayMsg = "";
                foreach (var method in outputMethods)
                {
                    if (method != null) displayMsg += $"{(int)method} {method}\n";
                }

                ConsoleHandler.OutputData(displayMsg);

                userSelectedMethod = int.Parse(ConsoleHandler.HandleUserInput());

                isValidInput = Enum.IsDefined(typeof(OutputMethod), userSelectedMethod) ;
            }

            return (OutputMethod) userSelectedMethod;
        }

        public static string GetText()
        {
            DisplayUi("Please specify the text", true);
            bool isValid = false;
            var text = "";

            while (!isValid)
            {
                text = PromptUser();
                isValid = !String.IsNullOrWhiteSpace(text);

                if (!isValid)
                {
                    DisplayUi("Empty text is not allowed", true);
                }
            }

            return text;
        }

        public static int GetSize()
        {
            bool isValid = false;
            DisplayUi("Please, select size", true);
            int size = 10;
            while (!isValid)
            {
                isValid = int.TryParse(PromptUser(), out size);
                if (size < 5)
                {
                    DisplayUi("Please select size > 5", true);
                    isValid = false;
                }
            }

            return size;
        }


        public static CoordinatesPoint GetStartingPoint()
        {
            bool isValid = false;
            DisplayUi("Please, select starting point in format 'x , y'", true);
            int x = 1;
            int y = 1;
            while (!isValid)
            {
                var coordinates = PromptUser().Split(',');
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

                DisplayUi("The incorrect input", true);
            }

            return new CoordinatesPoint(x - 1, y - 1);
        }

        private static void AskStopProgram(Action continueProgram)
        {
            DisplayUi("\nDraw a new picture? 'Y' to continue", true);
            if (DetectKeyPress != null && DetectKeyPress().Key is ConsoleKey.Y)
            {
                continueProgram();
            }
        }

        private static void AskAddAnotherShape(Action addAnotherShape)
        {
            while (true)
            {
                DisplayUi("\nAdd another object to Printer queue? Y/N", true);
                if (DetectKeyPress != null)
                {
                    var userKey = DetectKeyPress().Key;
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

        private static List<object> CollectArgsForPrintableObj(Type printableObj)
        {
            var args = new List<object>();
            if (printableObj == typeof(PrintableText))
            {
                var text = UiHandler.GetText();
                args.Add(text);
                
            }
            else
            {
                var printableChar = UiHandler.GetPrintingChar();
                args.Add(printableChar);
                var size = UiHandler.GetSize();
                args.Add(size);
            }

            return args;
        }

        public static void StopProgram()
        {
            Environment.Exit(0);
        }
    }
}
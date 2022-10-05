#nullable enable
using System;
using System.Collections.Generic;
using ShapeCreator;
using ShapeCreator.Objects;
using SharedAssets;

namespace UserInterface
{
    public class UiHandler
    {
        private static List<Type>? _printableTypes;

        private Action<string, List<ConsoleColor>> DisplayShape { get; }

        private Action<string, bool> DisplayUi { get; }

        private Func<string> PromptUser { get; }

        public Func<ConsoleKeyInfo> DetectKeyPress;

        private readonly Printer.Printer _printer = new Printer.Printer();

        public UiHandler()
        {
            _printableTypes = AssemblyLoader.GetPrintableTypes();
            DisplayShape = DependencyInjector.GetShapeOutputMethod(this);
            DisplayUi = DependencyInjector.GetUiOutputMethod(this);
            PromptUser = DependencyInjector.GetUiInputMethod(this);
            // DetectKeyPress is initialized in a line above
            _printer.PrintEvent += AskStopProgram;
        }
        public void RenderMainMenu()
        {
            AddShapeToQueue();
            _printer.Print(DisplayShape);
        }

        
        internal void AddShapeToQueue()
        {
            var printableType = _printableTypes[GetPrintableObjId()];
            var printableArgs = CollectArgsForPrintableObj(printableType);
            var objToPrint = PrintableFactory.CreatePrintableObject(printableType, printableArgs);
            
            var startingPoint = GetStartingPoint();
            var printingScheme = objToPrint.GetPrintingScheme();
            _printer.AddToQueue(printingScheme, startingPoint, printableType);
            
            AskAddAnotherShape(DependencyInjector.GetAddShapeAction(this));
        }


        private char GetPrintingChar()
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

        private int GetPrintableObjId()
        {
            Console.Clear();
            for (int i = 1; i <= _printableTypes.Count; i++)
            {
                DisplayUi($"{i} {_printableTypes[i - 1].Name}", true);
            }

            bool isValid = false;
            int index = 0;

            DisplayUi("Please, select a printable entity or press Q to stop program", true);
            while (!isValid)
            {
                var userInput = PromptUser();

                isValid = Int32.TryParse(userInput, out var number);
                if (isValid && number >= 1 && number <= _printableTypes.Count)
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

        internal OutputMethod PromptForOutputMethod()
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

                isValidInput = Enum.IsDefined(typeof(OutputMethod), userSelectedMethod);
            }

            return (OutputMethod)userSelectedMethod;
        }

        private string GetText()
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

        private int GetSize()
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


        private CoordinatesPoint GetStartingPoint()
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

        private void AskStopProgram(object? sender, EventArgs args)
        {
            DisplayUi("\nDraw a new picture? 'Y' to continue", true);
            if (DetectKeyPress != null && DetectKeyPress().Key is ConsoleKey.Y)
            {
                DependencyInjector.GetContinueProgramAction(this)?.Invoke();
            }
        }

        private void AskAddAnotherShape(Action addAnotherShape)
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

        private List<object> CollectArgsForPrintableObj(Type printableObj)
        {
            var args = new List<object>();
            if (printableObj == typeof(PrintableText))
            {
                var text = GetText();
                args.Add(text);
            }
            else
            {
                var printableChar = GetPrintingChar();
                args.Add(printableChar);
                var size = GetSize();
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
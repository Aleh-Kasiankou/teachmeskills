using System;
using System.Linq;

namespace ShapePrinter
{
    public static class Printer
    {
        private static string AddMargins(string RawText, (int, int) coordinates)
        {
            string topMargin = string.Concat(Enumerable.Repeat("\n", coordinates.Item2));
            string horizontalMargin = string.Concat(Enumerable.Repeat(" ", coordinates.Item1));

            var rawRepresentation = RawText.Split("\n");
            string processedText = topMargin;
            foreach (var line in rawRepresentation)
            {
                processedText += horizontalMargin + line + "\n";
            }

            return processedText;
        }

        public static void Print(Shape shape, (int, int) coordinates)
        {
            string finalString = AddMargins(shape.GetStringRepresentation(), coordinates);
            
            Console.Write(finalString);
        }
    }
}
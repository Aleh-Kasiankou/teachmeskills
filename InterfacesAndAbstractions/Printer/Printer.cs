using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharedAssets;

namespace Printer
{
    public static class Printer
    {
        private static List<List<CoordinatesPoint>> Queue { get; set; } = new List<List<CoordinatesPoint>>();

        public static void AddToQueue(List<CoordinatesPoint> printableScheme)
        {
            Queue.Add(printableScheme);
        }

        public static void ClearQueue()
        {
            Queue = new List<List<CoordinatesPoint>>();
        }


        private static List<CoordinatesPoint> MergeQueue()
        {
            var drawingScheme = new List<CoordinatesPoint>();
            foreach (var printableEntity in Queue)
            {
                drawingScheme.AddRange(printableEntity);
            }

            drawingScheme = PrintHelper.SortPointsByYAndX(drawingScheme);

            ClearQueue();

            return drawingScheme;
        }

        private static string ConvertSchemeToString(List<CoordinatesPoint> drawingScheme,
            out List<ConsoleColor> colorScheme)
        {
            var textScheme = new StringBuilder();
            colorScheme = new List<ConsoleColor>();

            var lastPointY = 1;
            if (drawingScheme[0].Y > 1)
            {
                textScheme.Append(String.Concat(Enumerable.Repeat("\n", drawingScheme[0].Y - 1)));
            }

            for (int index = 0; index < drawingScheme.Count; index++)
            {
                var point = drawingScheme[index];
                var margin = "";
                if (point.Y != lastPointY)
                {
                    margin = "\n";
                }

                var spacesNeeded = PrintHelper.CalculateLeftMargin(drawingScheme, index, out bool isSkip);
                if (isSkip)
                {
                    continue;
                }

                if (spacesNeeded > 0)
                {
                    margin += String.Concat(Enumerable.Repeat(" ", spacesNeeded));
                }


                textScheme.Append(margin + point.Symbol);
                if (!char.IsWhiteSpace(point.Symbol))
                {
                    colorScheme.Add(point.Color);
                }

                lastPointY = point.Y;
            }

            return textScheme.ToString();
        }


        public static void Print(Action<string, List<ConsoleColor>> outputString)
        {
            var drawingScheme = MergeQueue();
            var textScheme = ConvertSchemeToString(drawingScheme, out var colorScheme);
            outputString(textScheme, colorScheme);
        }
    }
}
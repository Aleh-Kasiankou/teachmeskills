using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapePrinter
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

            return drawingScheme;
        }


        public static void Print()
        {
            Console.Clear();
            var drawingScheme = MergeQueue();
            ClearQueue();

            var lastPointY = 1;
            if (drawingScheme[0].Y > 1)
            {
                Console.Write(String.Concat(Enumerable.Repeat("\n", drawingScheme[0].Y - 1)));
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

                Console.Write(margin + point.Symbol);
                lastPointY = point.Y;
            }
        }
    }
}
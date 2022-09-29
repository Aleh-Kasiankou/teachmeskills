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

        private static int CalculateLeftMargin(List<CoordinatesPoint> scheme,
                int currentPointIndex, out bool isSkip)
            //the scheme is sorted
        {
            var currentPoint = scheme[currentPointIndex];
            var point = currentPointIndex > 0
                ? scheme[currentPointIndex - 1]
                : new CoordinatesPoint(0, 1, currentPoint.Symbol);

            var margin = currentPoint.X - 1;

            CoordinatesPoint closestPointToLeft = new CoordinatesPoint(0, currentPoint.Y, currentPoint.Symbol);
            isSkip = false;


            bool isSameLine = point.Y == currentPoint.Y;
            bool isLeftFromCurrentPoint = point.X < currentPoint.X;
            bool isCloser = point.X > closestPointToLeft.X;

            isSkip = isSameLine && point.X == currentPoint.X;

            if (isSameLine && isLeftFromCurrentPoint && isCloser)
            {
                closestPointToLeft = point;
            }

            margin -= closestPointToLeft.X;
            return margin;
        }

        private static List<CoordinatesPoint> MergeQueue()
        {
            var drawingScheme = new List<CoordinatesPoint>();
            foreach (var printableEntity in Queue)
            {
                drawingScheme.AddRange(printableEntity);
            }

            CoordinatesPoint temp;
            for (int j = 0; j <= drawingScheme.Count - 2; j++)
            {
                for (int i = 0; i <= drawingScheme.Count - 2; i++)
                {
                    if (drawingScheme[i].Y > drawingScheme[i + 1].Y)
                    {
                        temp = drawingScheme[i + 1];
                        drawingScheme[i + 1] = drawingScheme[i];
                        drawingScheme[i] = temp;
                    }

                    else if (drawingScheme[i].Y == drawingScheme[i + 1].Y)
                    {
                        if (drawingScheme[i].X > drawingScheme[i + 1].X)
                        {
                            temp = drawingScheme[i + 1];
                            drawingScheme[i + 1] = drawingScheme[i];
                            drawingScheme[i] = temp;
                        }

                        else if (drawingScheme[i].X == drawingScheme[i + 1].X)
                        {
                            var conflictSymbol = '$';
                            drawingScheme[i] = new CoordinatesPoint(drawingScheme[i].X, drawingScheme[i].Y, conflictSymbol);
                            drawingScheme[i + 1] = new CoordinatesPoint(drawingScheme[i + 1].X, drawingScheme[i + 1].Y,
                                conflictSymbol);
                        }
                    }
                }
            }

            return drawingScheme;
        }

        public static List<CoordinatesPoint> AdaptForPrinting(List<CoordinatesPoint> drawingScheme)
        {
            var addToX = 0;
            var addToY = 0;
            foreach (var point in drawingScheme)
            {
                if (point.X < 0 && Math.Abs(point.X) > addToX)
                {
                    addToX = (Math.Abs(point.X)) + 1;
                }

                if (point.Y < 0 && Math.Abs(point.Y) > addToY)
                {
                    addToY = (Math.Abs(point.Y)) + 1;
                }
            }

            for (int i = 0; i < drawingScheme.Count; i++)
            {
                var point = drawingScheme[i];
                point.X += addToX;
                point.Y += addToY;
                // drawingScheme[i] = valueTuple;
            }

            return drawingScheme;
        }

        public static void Print()
        {
            Console.Clear();
            var drawingScheme = MergeQueue();


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

                var spacesNeeded = CalculateLeftMargin(drawingScheme, index, out bool isSkip);
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
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapePrinter
{
    public static class Printer
    {
        private static List<List<ValueTuple<int, int, char>>> Queue { get; set; } = new List<List<(int, int, char)>>();

        public static void AddToQueue(List<ValueTuple<int, int, char>> printableScheme)
        {
            Queue.Add(printableScheme);
        }

        public static void ClearQueue()
        {
            Queue = new List<List<(int, int, char)>>();
        }

        private static int CalculateLeftMargin(List<ValueTuple<int, int, char>> scheme,
                int currentPointIndex, out bool isSkip)
            //the scheme is sorted
        {
            var currentPoint = scheme[currentPointIndex];
            var point = currentPointIndex > 0 ? scheme[currentPointIndex - 1] : (0, 1, currentPoint.Item3);

            var margin = currentPoint.Item1 - 1;

            ValueTuple<int, int, char> closestPointToLeft = (0, currentPoint.Item2, currentPoint.Item3);
            isSkip = false;


            bool isSameLine = point.Item2 == currentPoint.Item2;
            bool isLeftFromCurrentPoint = point.Item1 < currentPoint.Item1;
            bool isCloser = point.Item1 > closestPointToLeft.Item1;

            isSkip = isSameLine && point.Item1 == currentPoint.Item1;

            if (isSameLine && isLeftFromCurrentPoint && isCloser)
            {
                closestPointToLeft = point;
            }

            margin -= closestPointToLeft.Item1;
            return margin;
        }

        private static List<(int, int, char)> MergeQueue()
        {
            var drawingScheme = new List<(int, int, char)>();
            foreach (var printableEntity in Queue)
            {
                drawingScheme.AddRange(printableEntity);
            }

            (int, int, char) temp;
            for (int j = 0; j <= drawingScheme.Count - 2; j++)
            {
                for (int i = 0; i <= drawingScheme.Count - 2; i++)
                {
                    if (drawingScheme[i].Item2 > drawingScheme[i + 1].Item2)
                    {
                        temp = drawingScheme[i + 1];
                        drawingScheme[i + 1] = drawingScheme[i];
                        drawingScheme[i] = temp;
                    }

                    else if (drawingScheme[i].Item2 == drawingScheme[i + 1].Item2)
                    {
                        if (drawingScheme[i].Item1 > drawingScheme[i + 1].Item1)
                        {
                            temp = drawingScheme[i + 1];
                            drawingScheme[i + 1] = drawingScheme[i];
                            drawingScheme[i] = temp;
                        }

                        else if (drawingScheme[i].Item1 == drawingScheme[i + 1].Item1)
                        {
                            var conflictSymbol = '$';
                            drawingScheme[i] = (drawingScheme[i].Item1, drawingScheme[i].Item2, conflictSymbol);
                            drawingScheme[i + 1] = (drawingScheme[i + 1].Item1, drawingScheme[i + 1].Item2,
                                conflictSymbol);
                        }
                    }
                }
            }

            return drawingScheme;
        }

        public static List<(int, int, char)> AdaptForPrinting(List<(int, int, char)> drawingScheme)
        {
            var addToX = 0;
            var addToY = 0;
            foreach (var point in drawingScheme)
            {
                if (point.Item1 < 0 && Math.Abs(point.Item1) > addToX)
                {
                    addToX = (Math.Abs(point.Item1)) + 1;
                }

                if (point.Item2 < 0 && Math.Abs(point.Item1) > addToY)
                {
                    addToY = (Math.Abs(point.Item1)) + 1;
                }
            }

            for (int i = 0; i < drawingScheme.Count; i++)
            {
                var valueTuple = drawingScheme[i];
                valueTuple.Item1 += addToX;
                valueTuple.Item2 += addToY;
                drawingScheme[i] = valueTuple;
            }

            return drawingScheme;
        }

        public static void Print()
        {
            Console.Clear();
            var drawingScheme = MergeQueue();


            var lastPointY = 1;
            if (drawingScheme[0].Item2 > 1)
            {
                Console.Write(String.Concat(Enumerable.Repeat("\n", drawingScheme[0].Item2 - 1)));
            }

            for (int index = 0; index < drawingScheme.Count; index++)
            {
                var point = drawingScheme[index];
                var margin = "";
                if (point.Item2 != lastPointY)
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

                Console.Write(margin + point.Item3);
                lastPointY = point.Item2;
            }
        }
    }
}
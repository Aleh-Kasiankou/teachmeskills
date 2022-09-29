using System;
using System.Collections.Generic;

namespace ShapePrinter
{
    public static class PrintHelper
    {
        public static int CalculateLeftMargin(List<CoordinatesPoint> scheme,
                int currentPointIndex, out bool isSkip)
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
        
        public static List<CoordinatesPoint> ConvertToPositiveCoordinates(List<CoordinatesPoint> drawingScheme)
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
            }

            return drawingScheme;
        }

        public static List<CoordinatesPoint> MoveStartingPoint(List<CoordinatesPoint> printingScheme)
        {
            var startingPoint = UiHandler.GetStartingPoint();
            for (int i = 0; i < printingScheme.Count; i++)
            {
                var x = printingScheme[i].X + startingPoint.X;
                var y = printingScheme[i].Y + startingPoint.Y;
                var character = printingScheme[i].Symbol;
                printingScheme[i] = new CoordinatesPoint(x, y, character);
            }

            return printingScheme;
        }

        public static List<CoordinatesPoint> SortPointsByYAndX(List<CoordinatesPoint> drawingScheme)
        {
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
    }
}
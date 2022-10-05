using System;
using System.Collections.Generic;
using SharedAssets;

namespace ShapeCreator.Objects
{
    [Color(ConsoleColor.Yellow)]
    public class Circle : Shape
    {
        public Circle(char delimiter = '*', int size = 20) : base(delimiter, size)
        {
        }

        public override List<CoordinatesPoint> GetPrintingScheme()
        {
            var printingPoints = new List<CoordinatesPoint>();
            var radius = Size / 2;
            var x = -radius;
            var y = -radius;
            while (y <= radius)
            {
                bool isCirclePoint = Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(radius, 2);


                if (isCirclePoint)
                {
                    printingPoints.Add(
                        new CoordinatesPoint(x, y, Delimiter));
                }

                if (x > radius)
                {
                    y++;
                    x = -radius;
                    continue;
                }

                x++;
            }

            return printingPoints;
        }
    }
}
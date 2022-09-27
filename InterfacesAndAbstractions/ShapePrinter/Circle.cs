using System;
using System.Collections.Generic;

namespace ShapePrinter
{
    public class Circle : Shape
    {
        public Circle(int size) : base(size)
        {
        }

        public override List<(int, int, char)> GetPrintingScheme()
        {
            var printingPoints = new List<(int x, int y, char Delimiter)>();
            var radius = Size / 2;
            var x = -radius;
            var y = -radius;
            while (y <= radius)
            {
                bool isCirclePoint = Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(radius, 2);


                if (isCirclePoint)
                {
                    printingPoints.Add(
                        new ValueTuple<int, int, char>(x, y, Delimiter));
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
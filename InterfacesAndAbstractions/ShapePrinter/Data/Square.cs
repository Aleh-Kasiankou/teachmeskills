using System;
using System.Collections.Generic;

namespace ShapePrinter.Data
{
    [Color(ConsoleColor.DarkCyan)]
    public class Square : Shape
    {
        public Square(int size, char printingChar) : base(size, printingChar)
        {
        }

        public override List<CoordinatesPoint> GetPrintingScheme()
        {
            var printingPoints = new List<CoordinatesPoint>();
            var halfSize = Size / 2;
            var x = -halfSize;
            var y = -halfSize;
            while (y <= halfSize)
            {
                bool isRow = Math.Abs(y) == Math.Abs(halfSize);
                bool isColumn = Math.Abs(x) == Math.Abs(halfSize);
                if (isRow || isColumn)
                {
                    printingPoints.Add(new CoordinatesPoint(x, y, Delimiter));
                }

                if (x > 0 && isColumn)
                {
                    y++;
                    x = -halfSize;
                    continue;
                }

                x++;
            }

            return printingPoints;
        }
    }
}
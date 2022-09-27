using System;
using System.Collections.Generic;

namespace ShapePrinter
{
    public class Square : Shape
    {
        public Square(int size, char printingChar) : base(size, printingChar)
        {
        }
        
        public override List<ValueTuple<int, int, char>> GetPrintingScheme()
        {
            var printingPoints = new List<(int x, int y, char Delimiter)>();
            var halfSize = Size / 2;
            var x = - halfSize;
            var y = -halfSize;
            while (y <= halfSize)
            {
                bool isRow = Math.Abs(y) == Math.Abs(halfSize);
                bool isColumn = Math.Abs(x) == Math.Abs(halfSize) ;
                if (isRow || isColumn)
                {
                    printingPoints.Add(new ValueTuple<int, int, char>(x, y, Delimiter));
                }

                if (x > 0 && isColumn)
                {
                    y++;
                    x = - halfSize;
                    continue;
                }

                x ++;
            }

            return printingPoints;
        }
    }
}
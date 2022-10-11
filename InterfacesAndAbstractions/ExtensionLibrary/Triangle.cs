using System.Collections.Generic;
using ShapeCreator;
using SharedAssets;


namespace ExtensionLibrary
{
    public class Triangle : Shape
    {
        public Triangle(char delimiter = '*', int size = 20) : base(delimiter, size)
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
                var y1 = y < 0 ? -halfSize : halfSize;

                var dx1 = halfSize - -halfSize;
                var dy1 = 0 - y1;

                var dx = x - -halfSize;
                var dy = y - y1;

                var s = dx1 * dy - dx * dy1;

                if (x == -halfSize || (y == 0 && x == halfSize) || s == 0)
                {
                    printingPoints.Add(new CoordinatesPoint(x, y, Delimiter));
                }


                if (x >= halfSize)
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
using System;
using System.Collections.Generic;

namespace ShapePrinter
{
    public class PrintableText : IPrintable
    {
        private string Body { get; set; }

        public PrintableText(string input)
        {
            Body = input;
        }

        public List<CoordinatesPoint> GetPrintingScheme()
        {
            var printingPoints = new List<CoordinatesPoint>();
            var x = 1;
            var y = 1;
            foreach (var character in Body)
            {
                printingPoints.Add(new CoordinatesPoint(x, y, character));
                x++;
            }

            return printingPoints;
        }
    }
}
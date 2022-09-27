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

        public List<(int, int, char)> GetPrintingScheme()
        {
            var printingPoints = new List<(int x, int y, char Delimiter)>();
            var x = 1;
            var y = 1;
            foreach (var character in Body)
            {
                printingPoints.Add(new ValueTuple<int, int, char>(x, y, character));
                x++;
            }

            return printingPoints;
        }
    }
}
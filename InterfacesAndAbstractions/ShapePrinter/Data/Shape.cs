using System;
using System.Collections.Generic;

namespace ShapePrinter.Data
{
    public abstract class Shape : IPrintable
    {
        protected char Delimiter { get; }
        protected int Size { get; }

        protected Shape(int size = 10, char delimiter = '*')
        {
            if (size < 5)
            {
                throw new Exception(message: "Wrong Size");
            }

            Size = size;
            Delimiter = delimiter;
        }

        public abstract List<CoordinatesPoint> GetPrintingScheme();
    }
}
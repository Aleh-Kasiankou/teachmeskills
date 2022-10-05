using System;
using System.Collections.Generic;
using SharedAssets;

namespace ShapeCreator
{
    public abstract class Shape : IPrintable
    {
        protected char Delimiter { get; }
        protected int Size { get; }

        protected Shape(char delimiter = '*', int size = 10)
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
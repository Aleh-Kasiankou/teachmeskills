using System;
using System.Collections.Generic;
using ShapeCreator.Objects;


namespace ShapeCreator
{
    public static class PrintableFactory
    {
        public static IPrintable
            CreatePrintableObject(Type printableType, List<object> args) 
        // TODO Add Exception check

        {
            IPrintable objToPrint =
                (IPrintable)Activator.CreateInstance(printableType, args.ToArray());

            return objToPrint;
        }
    }
}
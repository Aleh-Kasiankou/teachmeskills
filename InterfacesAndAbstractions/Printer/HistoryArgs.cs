using System;
using System.Collections.Generic;
using SharedAssets;

namespace Printer
{
    public class HistoryArgs : EventArgs
    {
        public Type Type { get; }
        public List<Type> PrintedWith { get; } = new List<Type>();

        public HistoryArgs(Type type, List<PrinterQueueElement> printedWith)
        {
            Type = type;
            foreach (PrinterQueueElement shape in printedWith)
            {
                PrintedWith.Add(shape.Type);
            }
        }
    }
}
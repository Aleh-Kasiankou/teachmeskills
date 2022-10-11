using System;
using System.Collections.Generic;

namespace Printer
{
    public class HistoryRecord
    {
        public Type Type { get; }
        public DateTime DatePrinted { get; }
        public List<Type> PrintedWith { get; } = new List<Type>();

        public HistoryRecord(Type type, List<Type> printedWith)
        {
            Type = type;
            DatePrinted = DateTime.Now;
            foreach (var shapeType in printedWith)
            {
                PrintedWith.Add(shapeType);
            }
        }
    }
}
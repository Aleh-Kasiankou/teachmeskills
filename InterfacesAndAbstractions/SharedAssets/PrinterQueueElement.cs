using System;
using System.Collections.Generic;

namespace SharedAssets
{
    public class PrinterQueueElement
    {
        public Type Type { get; set; }
        public List<CoordinatesPoint> DrawingScheme { get; }

        public PrinterQueueElement(Type type, List<CoordinatesPoint> drawingScheme)
        {
            Type = type;
            DrawingScheme = drawingScheme;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ShapePrinter
{
    public interface IPrintable
    {
        public List<CoordinatesPoint> GetPrintingScheme();
        
    }
}
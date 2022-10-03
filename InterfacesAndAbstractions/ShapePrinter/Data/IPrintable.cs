using System.Collections.Generic;

namespace ShapePrinter.Data
{
    public interface IPrintable
    {
        public List<CoordinatesPoint> GetPrintingScheme();
    }
}
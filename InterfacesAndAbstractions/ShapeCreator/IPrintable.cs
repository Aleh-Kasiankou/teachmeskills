using System.Collections.Generic;
using SharedAssets;

namespace ShapeCreator
{
    public interface IPrintable
    {
        public List<CoordinatesPoint> GetPrintingScheme();
    }
}
using System.Collections.Generic;

namespace SharedAssets
{
    public interface IPrintable
    {
        public List<CoordinatesPoint> GetPrintingScheme();
    }
}
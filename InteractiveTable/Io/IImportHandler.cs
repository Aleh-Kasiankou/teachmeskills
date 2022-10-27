using System.Collections.Generic;
using Logger;

namespace Io
{
    public interface IImportHandler<T>
    {
        public string FilePath { get;}
        public List<T> ImportTable();
        
        public ILogger Logger { get;}

        public void ExportData(List<object> dataToExport);
        
        public void ExportData(List<T> dataToExport);
    }
}
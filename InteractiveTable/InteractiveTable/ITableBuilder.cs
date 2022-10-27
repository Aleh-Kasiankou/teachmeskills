using System.Collections.Generic;

namespace InteractiveTable
{
    public interface ITableBuilder<T>
    {
        public Table CreateTable(List<T> dataList);

        public List<object> ConvertTableToData(Table table);
    }
}
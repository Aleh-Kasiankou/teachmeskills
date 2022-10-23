using System;
using System.Collections.Generic;
using System.Reflection;
using Logger;

namespace InteractiveTable
{
    public class TableBuilder<T>
    {
        private readonly ILogger _logger;
        public PropertyInfo[] Props { get; set; } = typeof(T).GetProperties();

        public TableBuilder(ILogger logger)
        {
            _logger = logger;
        }

        public Table CreateTable(List<T> dataList)
        {
            _logger?.Log("Building new table", LogLevel.Info);
            
            var table = new Table("People", _logger);
            SetTableLayout(Props, table);
            FillTable(table, dataList, Props);

            return table;
        }

        private void SetTableLayout(PropertyInfo[] props, Table table)
        {
            
            foreach (var prop in props)
            {
                Type propType = prop.PropertyType;
                table.AddColumn(propType, prop.Name);
            }
        }

        private void FillTable(Table table, List<T> peopleData, PropertyInfo[] props)
        {
            _logger?.Log("Filling table with imported data", LogLevel.Info);
            foreach (T T in peopleData)
            {
                foreach (var prop in props)
                {
                    table.AppendData(prop.GetValue(T));
                }
            }

            _logger?.Log($"Added {peopleData.Count} imported entries to {table.Identifier} table", LogLevel.Info);
        }
        
        public List<T> ConvertTableToData(Table table)
        {
            _logger?.Log($"Converting table {table.Identifier} to list of {nameof(T)} to save", LogLevel.Info);
            List<object> args = new List<object>();
            List<T> data = new List<T>();

            foreach (var row in table.Rows)
            {
                foreach (var column in table.Columns)
                {
                    var prop = table.ReadCell(column.Identifier, row);
                    args.Add(prop);
                }

                T dataItem = (T)Activator.CreateInstance(typeof(T), args.ToArray());
                data.Add(dataItem);
                args = new List<object>();
            }

            return data;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Logger;

namespace InteractiveTable
{
    public class Table
    {
        private Table()
        {
        }

        public Table(string identifier, ILogger logger = null)
        {
            LastCell = new TablePointer(this);
            Identifier = identifier;
            _logger = logger;
            NameProvider = new NameProvider(logger);
        }


        public string Identifier { get; set; }
        private TablePointer LastCell { get; set; }
        public List<Column> Columns { get; } = new List<Column>();
        public List<string> Rows { get; set; } = new List<string>();
        private readonly ILogger _logger;
        public int PageSize { get; set; } = 5;
        private NameProvider NameProvider { get; }

        public void AddColumn(Type type, string columnTitle)
        {
            _logger?.Log($"Adding column {columnTitle}", LogLevel.Info);
            var identifier = NameProvider.GenerateIdentifier(TableEntity.Column);
            var newColumn = new Column(identifier, type, columnTitle);
            Columns.Add(newColumn);
        }

        public void WriteData(string columnId, string row, object value)
        {
            _logger?.Log($"Attempt to write {value} to {Identifier} table [{columnId}, {row}]", LogLevel.Info);
            AppendRows(row);
            Column column = FindColumn(columnId);
            column.WriteToRow(row, value);
        }

        public void AppendData(object obj)
        {
            _logger?.Log($"Writing {obj} to {Identifier} table [{LastCell.ColumnId}, {LastCell.RowId}]", LogLevel.Info);
            WriteData(LastCell.ColumnId, LastCell.RowId, obj);
            LastCell.Next();
        }

        public object ReadCell(string columnId, string row)
        {
            Column column = FindColumn(columnId);
            var data = column.ReadRow(row);
            return data;
        }

        public List<object> ReadRow(string row)
        {
            var rowData = new List<object>();
            foreach (var column in Columns)
            {
                rowData.Add(column.ReadRow(row));
            }

            return rowData;
        }

        public List<List<object>> ReadPage(int page) // unfinished pagination. Need page validation
        {
            var pageData = new List<List<object>>();

            for (int i = 1; pageData.Count < PageSize; i++)
            {
                if (i >= (page - 1) * PageSize)
                {
                    pageData.Add(ReadRow(i.ToString()));
                }
            }

            return pageData;
        }

        private void AppendRows(string row)
        {
            _logger.Log($"Attempt to create rows to {row}", LogLevel.Warning);
            NameProvider.ValidateRowName(row);

            if (!Rows.Contains(row))
            {
                do
                {
                    AppendRow();
                } while (Rows[^1] != row);
            }
        }

        private void AppendRow()
        {
            _logger?.Log("Adding new row", LogLevel.Info);
            var rowToAdd = NameProvider.GenerateIdentifier(TableEntity.Row);
            Rows.Add(rowToAdd);
        }


        private Column FindColumn(string identifier)
        {
            _logger?.Log($"Validating column name {identifier}", LogLevel.Info);
            foreach (var column in Columns)
            {
                if (column.Identifier == identifier)
                {
                    return column;
                }
            }

            _logger?.Log($"Failed to find column {identifier}", LogLevel.Warning);
            throw new ArgumentException($"No such column '{identifier}'");
        }

        public override string ToString()
        {
            _logger?.Log("Building text representation of a table", LogLevel.Info);
            var stringRepresentation = new StringBuilder($"Table {Identifier}\n");

            // add column names
            for (int i = 0; i < Columns.Count; i++)
            {
                var separator = i < Columns.Count - 1 ? "\t" : "\n";
                stringRepresentation.Append($"\t{Columns[i].Identifier}{separator}");
            }

            // add rows
            foreach (var rowIdentifier in Rows)
            {
                stringRepresentation.Append($"{rowIdentifier}\t");
                for (int i = 0; i < Columns.Count; i++)
                {
                    var separator = i < Columns.Count - 1 ? "\t|\t" : "\n";
                    stringRepresentation.Append($"{Columns[i].ReadRow(rowIdentifier)}{separator}");
                }
            }

            return stringRepresentation.ToString();
        }
    }
}
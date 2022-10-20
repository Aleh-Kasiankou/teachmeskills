using System;
using System.Collections.Generic;
using System.Text;
using Logger;
using Newtonsoft.Json;

namespace InteractiveTable
{
    public class Table
    {
        private Table()
        {
        }

        public Table(string identifier, ILogger logger)
        {
            LastCell = new TablePointer(this);
            Identifier = identifier;
            Logger = logger;
        }


        public string Identifier { get; set; }
        public TablePointer LastCell { get; set; }
        public List<Column> Columns { get; } = new List<Column>();
        public List<string> Rows { get; set; } = new List<string>();
        public ILogger Logger { get; }

        public void AddColumn(Type type, string columnTitle)
        {
            var identifier = TableHelper.GenerateIdentifier(TableEntity.Column);
            var newColumn = new Column(identifier, type, columnTitle);
            Columns.Add(newColumn);
        }

        public void WriteData(string columnId, string row, object value)
        {
            Logger.Log($"Attempt to write {value} to {Identifier} table [{columnId}, {row}]", LogLevel.Info);
            AppendRows(row);
            Column column = FindColumn(columnId);
            column.WriteToRow(row, value);
        }

        public void AppendData(object obj)
        {
            Logger.Log($"Writing {obj} to {Identifier} table [{LastCell.ColumnId}, {LastCell.RowId}]", LogLevel.Info);
            WriteData(LastCell.ColumnId, LastCell.RowId, obj);
            LastCell.Next();
        }

        public object ReadData(string columnId, string raw)
        {
            Column column = FindColumn(columnId);
            var data = column.ReadRow(raw);
            return data;
        }

        private void AppendRows(string row)
        {
            ValidateRowName(row);

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
            Logger.Log("Adding new row", LogLevel.Info);
            var rowToAdd = TableHelper.GenerateIdentifier(TableEntity.Row);
            Rows.Add(rowToAdd);
        }

        private void ValidateRowName(string row)
        {
            Logger.Log($"Validating row name {row}", LogLevel.Info);
            if (!int.TryParse(row, out _))
            {
                Logger.Log("Validation failed", LogLevel.Warning);
                throw new ArgumentException($"{row} is not valid row number");
            }
        }

        private Column FindColumn(string identifier)
        {
            Logger.Log($"Validating column name {identifier}", LogLevel.Info);
            foreach (var column in Columns)
            {
                if (column.Identifier == identifier)
                {
                    return column;
                }
            }

            Logger.Log($"Failed to find column {identifier}", LogLevel.Warning);
            throw new ArgumentException($"No such column '{identifier}'");
        }

        public override string ToString()
        {
            Logger.Log("Building text representation of a table", LogLevel.Info);
            var stringRepresentation = new StringBuilder($"Table {Identifier}\n");

            // add column names
            for (int i = 0; i < Columns.Count; i++)
            {
                var separator = i < Columns.Count - 1 ? "\t" : "\n";
                stringRepresentation.Append($"\t{Columns[i].Identifier}{separator}");
            }

            // add rows
            for (int j = 0; j < Rows.Count; j++)
            {
                // write one row
                var rowIdentifier = Rows[j];
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
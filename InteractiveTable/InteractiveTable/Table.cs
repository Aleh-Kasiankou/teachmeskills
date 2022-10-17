using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveTable
{
    public class Table
    {
        private Table()
        {
        }

        public Table(string identifier)
        {
            LastCell = new TablePointer(this);
            Identifier = identifier;
        }
        
        

        public string Identifier { get; set; }
        public TablePointer LastCell { get; set; }
        public List<Column> Columns { get; } = new List<Column>();
        public List<string> Rows { get; set; } = new List<string>();

        public void AddColumn(Type type, string identifier = "default")
        {
            if (identifier == "default")
            {
                identifier = TableHelper.GenerateIdentifier(TableEntity.Column);
            }

            var newColumn = new Column(identifier, type);
            Columns.Add(newColumn);
        }

        public void WriteData(string columnId, string row, object value)
        {
            AppendRows(row);
            Column column = FindColumn(columnId);
            column.WriteToRow(row, value);
            
        }

        public void AppendData(object obj)
        {
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
            var rowToAdd = TableHelper.GenerateIdentifier(TableEntity.Row);
            Rows.Add(rowToAdd);
        }

        private void ValidateRowName(string row)
        {
            if (!int.TryParse(row, out _))
            {
                throw new ArgumentException($"{row} is not valid row number");
            }
        }

        private Column FindColumn(string identifier)
        {
            foreach (var column in Columns)
            {
                if (column.Identifier == identifier)
                {
                    return column;
                }
            }

            throw new ArgumentException($"No such column '{identifier}'");
        }

        public override string ToString()
        {
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
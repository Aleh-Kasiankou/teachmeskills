namespace InteractiveTable
{
    public class TablePointer
    {
        private Table RefTable { get;}
        public string ColumnId { get; private set; }
        public string RowId { get; private set; }

        public TablePointer(Table table)
        {
            ColumnId = "A";
            RowId = "1";
            RefTable = table;
        }

        public void Next()
        {
            if (ColumnId != RefTable.Columns[^1].Identifier)
            {
                var charColumnId = char.Parse(ColumnId);
                ColumnId = (++charColumnId).ToString() ;
            }
            else
            {
                ColumnId = RefTable.Columns[0].Identifier;
                var rowId = int.Parse(RowId);
                RowId = (++rowId).ToString();
            }
        }
        
        
    }
}
namespace InteractiveTable
{
    public static class TableHelper
    {
        private static char ColumnNameHash { get; set; } = 'A';
        private static int RowNameHash { get; set; } = 1;
        public static string GenerateIdentifier(TableEntity entity)
        {
            string name;
            if (entity == TableEntity.Row)
            {
                name = RowNameHash.ToString();
                RowNameHash++;
            }

            else
            {
                name = ColumnNameHash.ToString();
                ColumnNameHash++;
            }

            return name;
        }
    }
}
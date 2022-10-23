using System;
using Logger;

namespace InteractiveTable
{
    public class NameProvider
    {
        public NameProvider (ILogger logger)
        {
            _logger = logger;
        }

        private readonly ILogger _logger;
        private char ColumnNameHash { get; set; } = 'A';
        private int RowNameHash { get; set; } = 1;

        public string GenerateIdentifier(TableEntity entity)
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

        public void ValidateRowName(string row)
        {
            _logger?.Log($"Validating row name {row}", LogLevel.Info);
            if (!int.TryParse(row, out _))
            {
                _logger?.Log("Validation failed", LogLevel.Warning);
                throw new ArgumentException($"{row} is not valid row number");
            }
        }
    }
}
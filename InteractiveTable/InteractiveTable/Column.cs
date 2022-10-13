using System;
using System.Collections.Generic;

namespace InteractiveTable
{
    public class Column
    {
        public string Identifier { get; }

        public Type ColumnType { get; }

        public Dictionary<string, object> Items { get;}
        
        
        public Column(string identifier, Type columnType)
        {
            Identifier = identifier;
            Items = new Dictionary<string, object>();
            ColumnType = columnType;
        }
        
        public Column(string identifier, Dictionary<string, object> items, Type columnType)
        {
            Identifier = identifier;
            Items = items;
            ColumnType = columnType;
        }
        

        public void WriteToRow(string row, object objToWrite)
        {
            ValidateType(objToWrite);
            Items[row] = objToWrite;
        }

        public void ClearRow(string row)
        {
            Items[row] = default;
        }

        public object ReadRow(string row)
        {
            bool keyExists = Items.TryGetValue(row, out object data);
            return keyExists ? data : default;
        }

        private void ValidateType(object obj)
        {
            var objType = obj.GetType();
            if (objType != ColumnType)
            {
                try
                {
                    Type type = ColumnType;
                    Convert.ChangeType(obj, type);
                }
                catch (Exception)
                {
                    throw new ArgumentException(
                        $"The column '{Identifier}' only accepts data of {ColumnType} type, {objType} given");
                }
                
            }
        }
    }
}
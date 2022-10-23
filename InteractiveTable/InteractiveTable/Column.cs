using System;
using System.Collections.Generic;

namespace InteractiveTable
{
    public class Column
    {
        public string Identifier { get; }

        public Type ColumnType { get; }

        private Dictionary<string, object> Items { get; }
        private string ColumnTitle { get; set; }

        private Column()
        {
        }

        public Column(string identifier, Type columnType, string columnTitle)
        {
            Identifier = identifier;
            Items = new Dictionary<string, object>();
            ColumnType = columnType;
            ColumnTitle = columnTitle;
        }

        public Column(string identifier, Dictionary<string, object> items, Type columnType)
        {
            Identifier = identifier;
            Items = items;
            ColumnType = columnType;
        }


        public void WriteToRow(string row, object objToWrite)
        {
            Items[row] = ValidateType(objToWrite);
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

        private object ValidateType(object obj)
        {
            var objType = obj?.GetType();
            object returnObj = obj;
            if (objType != ColumnType && objType != null)
            {
                try
                {
                    Type type = ColumnType;
                    Convert.ChangeType(obj, type);
                }
                catch (Exception)
                {
                    try
                    {
                        returnObj = Activator.CreateInstance(ColumnType, obj); // in case there is a suitable constructor
                    }

                    catch (Exception)
                    {
                        throw new ArgumentException(
                            $"The column '{Identifier}' only accepts data of {ColumnType} type, {objType} given");
                    }
                }
            }

            return returnObj;
        }
    }
}
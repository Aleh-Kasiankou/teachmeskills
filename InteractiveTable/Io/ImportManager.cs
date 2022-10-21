using System;
using System.Collections.Generic;
using System.IO;
using InteractiveTable;
using Logger;
using Newtonsoft.Json;

namespace Io
{
    public class ImportManager<T>
    {
        public string FilePath { get; set; } =
            "C:\\Users\\alehk\\OneDrive\\Документы\\TMS\\teachmeskills\\InteractiveTable\\Io\\bin\\Debug\\netcoreapp3.1\\samplePersonList.json";

        // @"../../../../\Io\bin\Debug\netcoreapp3.1\samplePersonList.json";
        public ILogger Logger { get; set; }

        public ImportManager(ILogger logger)
        {
            Logger = logger;
        }

        public List<T> ImportTable()
        {
            Logger.Log($"Importing Data from {FilePath}", LogLevel.Info);
            string jsonObject = ReadJsonFromFile();
            List<T> importedData = JsonConvert.DeserializeObject<List<T>>(jsonObject);
            return importedData;
        }

        private string ReadJsonFromFile()
        {
            FileStream stream = null;
            string json = null;

            try
            {
                stream = File.Open(FilePath, FileMode.OpenOrCreate);
                TextReader jsonReader = new StreamReader(stream);
                json = jsonReader.ReadToEnd();
            }

            finally
            {
                stream?.Dispose();
            }

            return json;
        }

        private List<T> ConvertTableToData(Table table)
        {
            Logger.Log($"Converting table {table.Identifier} to list of {nameof(T)} to save", LogLevel.Info);
            List<object> args = new List<object>();
            List<T> Data = new List<T>();

            foreach (var row in table.Rows)
            {
                foreach (var column in table.Columns)
                {
                    var prop = table.ReadData(column.Identifier, row);
                    args.Add(prop);
                }

                T dataItem = (T)Activator.CreateInstance(typeof(T), args.ToArray());
                Data.Add(dataItem);
                args = new List<object>();
            }

            return Data;
        }

        public void ExportData(object objToExport)
        {
            List<T> DataToExport = ConvertTableToData(objToExport as Table);
            Logger.Log($"Saving data to {FilePath}", LogLevel.Info);
            Stream stream = null;
            try
            {
                string json = JsonConvert.SerializeObject(DataToExport);
                stream = File.Open(FilePath, FileMode.Truncate);
                TextWriter jsonWriter = new StreamWriter(stream);
                jsonWriter.Write(json);
                jsonWriter.Flush();
            }

            finally
            {
                stream?.Dispose();
            }
        }
    }
}
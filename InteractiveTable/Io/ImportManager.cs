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
            Logger?.Log($"Importing Data from {FilePath}", LogLevel.Info);
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

        

        public void ExportData(List<T> dataToExport)
        {
            Logger?.Log($"Saving data to {FilePath}", LogLevel.Info);
            Stream stream = null;
            try
            {
                string json = JsonConvert.SerializeObject(dataToExport);
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
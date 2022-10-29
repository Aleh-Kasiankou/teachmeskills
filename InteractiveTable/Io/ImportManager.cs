using System;
using System.Collections.Generic;
using System.IO;
using InteractiveTable;
using Logger;
using Newtonsoft.Json;

namespace Io
{
    public class ImportManager<T> : IImportHandler<T>
    {
        public string FilePath { get; }

        public ILogger Logger { get; }

        
        public ImportManager(ILogger logger, IDataPathProvider pathProvider) 
        
        {
            Logger = logger;
            FilePath = pathProvider.Path;
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


        public void ExportData(List<object> dataToExport)
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
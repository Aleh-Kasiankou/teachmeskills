using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Io
{
    public class ImportManager<T>
    {

        public List<T> ImportData(string filePath = @"../../../../\Io\bin\Debug\netcoreapp3.1\samplePersonList.json")
        {
            string jsonObject = ReadJsonFromFile(filePath);
            List<T> importedData = JsonConvert.DeserializeObject<List<T>>(jsonObject);
            return importedData;
        }

        private string ReadJsonFromFile(string filePath = @"../../../../\Io\bin\Debug\netcoreapp3.1\samplePersonList.json")
        {
            FileStream stream = null;
            string json = null;
            
            try
            {
                stream = File.Open(filePath, FileMode.OpenOrCreate);
                TextReader jsonReader = new StreamReader(stream);
                json = jsonReader.ReadToEnd();
            }

            catch (ArgumentException)
            {
                // handle in some way
            }

            finally
            {
                stream?.Dispose();
            }

            return json;
            
        }
    }
}
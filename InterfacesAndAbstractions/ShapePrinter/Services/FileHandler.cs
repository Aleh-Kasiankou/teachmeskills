using System;
using System.Collections.Generic;
using System.IO;

namespace ShapePrinter.Services
{
    public static class FileHandler
    {
        public static void WriteSchemeToFile(string textScheme, List<ConsoleColor> colorScheme)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "shapes.txt";

            File.WriteAllText(path, textScheme);
        }
    }
}
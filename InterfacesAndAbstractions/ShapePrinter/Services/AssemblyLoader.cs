using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ShapePrinter.Data;

namespace ShapePrinter.Services
{
    public static class AssemblyLoader
    {
        private static Type _type = typeof(IPrintable);

        internal static List<Type> GetPrintableTypes()
        {
            string currentAssemblyFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] filePaths = Directory.GetFiles(currentAssemblyFolderPath, "*.dll",
                SearchOption.TopDirectoryOnly);

            List<string> usedAssembliesFilePaths = new List<string>();

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                usedAssembliesFilePaths.Add(assembly.Location);
            }


            foreach (string filePath in filePaths)
            {
                if (!usedAssembliesFilePaths.Contains(filePath))
                {
                    Assembly assembly = Assembly.LoadFrom(filePath);
                    AppDomain.CurrentDomain.Load(assembly.GetName());
                }
            }

            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => _type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract).ToList()?? new List<Type>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ShapeCreator;

namespace UserInterface
{
    public static class AssemblyLoader
    {
        private static readonly Type Type = typeof(IPrintable);

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
                .Where(p => Type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract).ToList()?? new List<Type>();
        }
    }
}
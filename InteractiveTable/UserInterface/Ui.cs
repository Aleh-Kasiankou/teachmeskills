using System;
using System.Collections.Generic;
using System.Reflection;
using InteractiveTable;
using Io;
using Logger;

namespace UserInterface
{
    public class Ui
    {
        private Table CurrentTable { get; set; }
        public ILogger Logger { get; set; }

        private ConsoleHandler ConsoleHandler { get; }

        private ImportManager<Person> ImportApp { get; }

        public Ui(ILogger logger = null)
        {
            Logger = logger ?? new FileLogger();
            ImportApp = new ImportManager<Person>(Logger);
            ConsoleHandler = new ConsoleHandler(Logger);
            ConsoleHandler.ExitEvent += FinishProgram;
        }

        public void Start()
        {
            if (CurrentTable is null)
            {
                var peopleData = ImportApp.ImportTable();
                BuildTable(peopleData);
                
            }
            
            

            RenderMenu();
        }

        private void RenderMenu()
        {
            Console.Clear();
            Console.WriteLine(CurrentTable);

            Console.WriteLine("Please, click one of the functional buttons to proceed:\n" +
                              $"{ConsoleHandler.Add} to Add new cells\n" +
                              $"{ConsoleHandler.Write} to Edit/Set a value for a cell\n" +
                              $"{ConsoleHandler.Delete} to Delete a Cell\n" +
                              $"{ConsoleHandler.Exit} to Stop Program\n");

            ConsoleHandler.HandleInput();
            RenderMenu();
        }


        private void BuildTable(List<Person> peopleData)
        {
            Logger.Log("Building new table", LogLevel.Info);
            var personProps = typeof(Person).GetProperties();
            CurrentTable = new Table("People", Logger);
            foreach (var prop in personProps)
            {
                Type propType = prop.PropertyType;
                CurrentTable.AddColumn(propType, prop.Name);
            }
        
            FillTable(personProps, peopleData);
            ConsoleHandler.Table = CurrentTable;
        }
        
        private void FillTable(PropertyInfo[] props, List<Person> peopleData)
        {
            Logger.Log("Filling table with imported data", LogLevel.Info);
            foreach (Person person in peopleData)
            {
                foreach (var prop in props)
                {
                    CurrentTable.AppendData(prop.GetValue(person));
                }
            }
        
            Logger.Log($"Added {peopleData.Count} imported entries to {CurrentTable.Identifier} table", LogLevel.Info);
        }

        private void FinishProgram()
        {
            ImportApp.ExportData(CurrentTable);
            Logger.Log("Program is stopping", LogLevel.Info);
            Environment.Exit(0);
        }
    }
}
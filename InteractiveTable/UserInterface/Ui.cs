using System;
using System.Collections.Generic;
using System.Reflection;
using InteractiveTable;
using Io;

namespace UserInterface
{
    public class Ui
    {
        private Table CurrentTable { get; set; }
        private List<Person> PeopleData { get; set; }

        private ConsoleHandler ConsoleHandler { get; } = new ConsoleHandler();

        public void Start()
        {
            if (PeopleData is null)
            {
                var importApp = new ImportManager<Person>();
                PeopleData = importApp.ImportData();
                BuildTable(PeopleData);
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
                              $"{ConsoleHandler.Delete} to Delete a Cell\n");

            ConsoleHandler.HandleInput();
            RenderMenu();
        }


        private void BuildTable(List<Person> peopleData)
        {
            var personProps = typeof(Person).GetProperties();
            CurrentTable = new Table("People");
            foreach (var prop in personProps)
            {
                Type propType = prop.PropertyType;
                CurrentTable.AddColumn(propType);
            }

            FillTable(personProps, peopleData);
            ConsoleHandler.Table = CurrentTable;
        }

        private void FillTable(PropertyInfo[] props, List<Person> peopleData)
        {
            foreach (Person person in peopleData)
            {
                foreach (var prop in props)
                {
                    CurrentTable.AppendData(prop.GetValue(person));
                }
            }
        }
    }
}
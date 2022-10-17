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

        public void Start()
        {
            var importApp = new ImportManager<Person>();
            List<Person> peopleData = importApp.ImportData();
            BuildTable(peopleData);
            Console.WriteLine(CurrentTable);
            RunUserAction();
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


        private void RunUserAction()
        {
            var action = PromptForAction();
        }

        private string PromptForAction()
        {
            return "Action selected";
        }
    }
}
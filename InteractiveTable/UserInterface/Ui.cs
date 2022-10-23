using System;
using InteractiveTable;
using Io;
using Logger;

namespace UserInterface
{
    public class Ui
    {
        private Table CurrentTable { get; set; }
        private ILogger Logger { get; set; }

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
                var tableBuilder = new TableBuilder<Person>(Logger);
                var table = tableBuilder.CreateTable(peopleData);
                CurrentTable = table;
                ConsoleHandler.Table = table;
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


        private void FinishProgram()
        {
            var tableBuilder = new TableBuilder<Person>(Logger);
            var dataToExport = tableBuilder.ConvertTableToData(CurrentTable);
            ImportApp.ExportData(dataToExport);
            Logger?.Log("Program is stopping", LogLevel.Info);
            Environment.Exit(0);
        }
    }
}
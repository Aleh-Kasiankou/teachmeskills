using System;
using System.Collections.Generic;
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
            ImportApp = new ImportManager<Person>(Logger, new DataPathProvider());
            ConsoleHandler = new ConsoleHandler(Logger);
            ConsoleHandler.ExitEvent += FinishProgram;
        }

        public void Start(Exception e)
        {
            if (CurrentTable is null)
            {
                var peopleData = ImportApp.ImportTable();
                var tableBuilder = new TableBuilder<Person>(Logger);
                var table = tableBuilder.CreateTable(peopleData);
                CurrentTable = table;
                ConsoleHandler.Table = table;
            }


            RenderMenu(e);
        }

        private void NotifyAboutCriticalError(Exception e)
        {
            var msg = $"Sorry, something went wrong:\n {e.Message}";
            ConsoleHandler.NotifyUser(msg);
        }

        private void RenderMenu(Exception e)
        {
            Console.Clear();

            if (!(e is null))
            {
                NotifyAboutCriticalError(e);
            }

            Console.WriteLine(CurrentTable);

            Console.WriteLine("Please, click one of the functional buttons to proceed:\n" +
                              $"{ConsoleHandler.Write} to Edit/Set a value for a cell\n" +
                              $"{ConsoleHandler.Delete} to Delete a Cell\n" +
                              $"{ConsoleHandler.Exit} to Stop Program\n");

            ConsoleHandler.HandleInput();
            RenderMenu(null);
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
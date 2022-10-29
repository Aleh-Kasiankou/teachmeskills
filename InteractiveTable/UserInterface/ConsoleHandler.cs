using System;
using InteractiveTable;
using Logger;

namespace UserInterface
{
    public sealed class ConsoleHandler
    {
        public const ConsoleKey Write = ConsoleKey.W;
        public const ConsoleKey Delete = ConsoleKey.D;
        public const ConsoleKey Exit = ConsoleKey.Backspace;
        public ILogger Logger{ get;}

        public Table Table { get; set; }

        public ConsoleHandler(ILogger logger)
        {
            Logger = logger;
            PressKeyEvent+= KeyHandler;
        }

        public void NotifyUser(string message)
        {
            Console.WriteLine(message);
        }

        public void HandleInput()
        {
            var key = Console.ReadKey();
            OnPressKeyEvent(this, new KeyPressEventArgs(key));
        }
        
        private void WriteCells()
        {
            var cellPosition = GetCellPosition();
            Console.WriteLine("Please type your value");
            var newValue = Console.ReadLine();
            Table.WriteData(cellPosition.Item1, cellPosition.Item2, newValue);
            
        }
        
        private void DeleteCells()
        {
            var cellPosition = GetCellPosition();
            Table.WriteData(cellPosition.Item1, cellPosition.Item2, null);
        }

        private (string, string) GetCellPosition()
        {
            Console.WriteLine("Please, type in a Column");
            var column = Console.ReadLine();
            Console.WriteLine("Please, type in a Row");
            var row = Console.ReadLine();
            return (column, row);
        }

        private event Action<object, KeyPressEventArgs> PressKeyEvent;

        private void OnPressKeyEvent(object sender, KeyPressEventArgs args)
        {
            PressKeyEvent?.Invoke(sender, args);
        }

        private void KeyHandler(object sender, KeyPressEventArgs args)
        {
            // event TableAction
            
            switch (args.Key.Key)
            {
                case Delete:
                    DeleteCells();
                    break;
                case Write:
                    WriteCells();
                    break;
                case Exit:
                {
                    OnExitEvent();
                    break;
                }
            }
        }

        public event Action ExitEvent;

        private void OnExitEvent()
        {
            ExitEvent?.Invoke();
        }
    }
}
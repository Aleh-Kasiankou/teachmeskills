using System;

namespace InteractiveTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Table("Lol");
            table.AddColumn(typeof(int));
            table.AddColumn(typeof(string));
            table.AddColumn(typeof(string));
            table.WriteData("B", "1", "Hello");
            Console.WriteLine(table);
            table.WriteData("A", "3", "9");
            Console.WriteLine(table);
        }
    }
}
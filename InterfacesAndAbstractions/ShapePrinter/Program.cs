using System;

namespace ShapePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer.Print(new Square(), (5,3));
        }
    }
}
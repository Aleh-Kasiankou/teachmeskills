using System;

namespace ShapePrinter
{
    public class CoordinatesPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }

        public ConsoleColor Color { get; set; }

        public CoordinatesPoint(int x, int y, char symbol = '*', ConsoleColor color = ConsoleColor.White)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Color = color;
        }
    }
}
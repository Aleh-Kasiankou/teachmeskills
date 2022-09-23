using System.Linq;

namespace ShapePrinter
{
    public class Square : Shape
    {
        private string getHorizontalBorder()
        {
            string border = "";
            for (int length = 0; length < Size; length++)
            {
                border += Delimiter;
            }

            return border;
        }

        public override string GetStringRepresentation()
        {
            var shapeHeight = Size / 2;
            string representation = "";

            representation += getHorizontalBorder();

            for (int height = 0; height < shapeHeight; height++)
            {
                representation += $"\n{Delimiter}{string.Concat(Enumerable.Repeat(" ", Size - 2))}{Delimiter}";
            }

            representation += "\n";

            representation += getHorizontalBorder();

            return representation;
        }
    }
}
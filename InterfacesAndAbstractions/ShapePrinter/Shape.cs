namespace ShapePrinter
{
    public abstract class Shape
    {
        protected virtual string Delimiter { get; }
        protected int Size { get; }

        protected Shape(int size = 10, string delimiter = "*")
        {
            Size = size;
            Delimiter = delimiter;
        }
        
        public abstract string GetStringRepresentation();
    }
}
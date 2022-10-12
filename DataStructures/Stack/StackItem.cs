namespace Stack
{
    public class StackItem<T>
    {
        public T Value { get; set; }
        public StackItem<T> PreviousItem { get; set; }

        public StackItem(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
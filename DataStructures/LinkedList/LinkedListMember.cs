namespace LinkedList
{
    public class LinkedListMember<T>
    {
        
        public T Value { get; set; }
        public LinkedListMember<T> NextItem { get; set; }

        public LinkedListMember(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
namespace Queue
{
    public class QueueMember<T>
    {
        public QueueMember<T> FollowingMember { get; set; }
        public T Value { get; set; }

        public QueueMember(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
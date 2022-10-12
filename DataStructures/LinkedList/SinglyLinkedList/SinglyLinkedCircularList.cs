namespace LinkedList.SinglyLinkedList
{
    public class SinglyLinkedCircularList<T> : SinglyLinkedList<T>
    {
        
        public SinglyLinkedCircularList(T[] array) : base(array)
        {
        }

        protected override void InsertLastListMember(T value)
        {
            base.InsertLastListMember(value);
            Tail.NextItem = Head;
        }

        public override void Reverse()
        {
            base.Reverse();
            Tail.NextItem = Head;
        }
    }
}
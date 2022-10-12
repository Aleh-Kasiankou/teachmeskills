namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedCircularList<T> : DoublyLinkedList<T>
    {
        public DoublyLinkedCircularList(T[] array) : base(array)
        {
        }

        protected override void InsertFirstListMember(T value)
        {
            base.InsertFirstListMember(value);
            ((DoublyLinkedListMember<T>)Head).PreviousItem = Tail;
            
        }

        protected override void InsertLastListMember(T value)
        {
            base.InsertLastListMember(value);
            Tail.NextItem = Head;
        }

        public override void Reverse()
        {
            base.Reverse();
            ((DoublyLinkedListMember<T>)Head).PreviousItem = Tail;
            Tail.NextItem = Head;
        }
    }
}
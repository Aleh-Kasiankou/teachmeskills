namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedListMember<T> : LinkedListMember<T>
    {
        public DoublyLinkedListMember(T value) : base(value)
        {
        }

        public LinkedListMember<T> PreviousItem { get; set; }
    }
}
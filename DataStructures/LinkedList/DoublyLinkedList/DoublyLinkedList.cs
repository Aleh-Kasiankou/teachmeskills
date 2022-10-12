namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : LinkedList<T>
    {
        public DoublyLinkedList(T[] array) : base(array)
        {
        }
    

    public override void Reverse() //recheck
    {
        for (int i = LastElementIndex; i >= 0; i--)
        {
            DoublyLinkedListMember<T> currentListMember = (DoublyLinkedListMember<T>)GetListMemberAt(i);
            (currentListMember.PreviousItem, currentListMember.NextItem) =
                (currentListMember.NextItem, currentListMember.PreviousItem);
        }

        (Head, Tail) = (Tail, Head);
    }

    protected override void InsertFirstListMember(T value)
    {
        Head = new DoublyLinkedListMember<T>(value) { NextItem = Head};

        if (LastElementIndex != -1) //crunch
        {
            var secondListMember = (DoublyLinkedListMember<T>)Head.NextItem;
            secondListMember.PreviousItem = Head;
        }
    }

    protected override void InsertNonMarginalElement(int index, T value)
    {
        LinkedListMember<T> prevListMember = GetListMemberAt(index - 1);
        var nextListMember = (DoublyLinkedListMember<T>) prevListMember.NextItem;

        var insertedListMember = new DoublyLinkedListMember<T>(value)
            { NextItem = nextListMember, PreviousItem = prevListMember };
        prevListMember.NextItem = insertedListMember;
        nextListMember.PreviousItem = insertedListMember;
    }

    protected override void InsertLastListMember(T value)
    {
        Tail.NextItem = new DoublyLinkedListMember<T>(value){PreviousItem = Tail};
        Tail = Tail.NextItem;
    }
}

}
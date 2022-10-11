namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : LinkedList<T>
    {
        public DoublyLinkedList(int size = 16) : base(size)
        {
        }

        public DoublyLinkedList(T[] array) : base(array)
        {
        }

        public override void Insert(T item, int index)
        {
            AdjustSize(LastElementIndex + 1);
            ValidateIndex(index);

            LinkedListMember<T> insertedListMember;
            if (index != 0)
            {
                LinkedListMember<T> prevListMember = GetListMemberAt(index - 1);
                DoublyLinkedListMember<T> nextListMember = prevListMember.NextItem as DoublyLinkedListMember<T>;

                insertedListMember = new DoublyLinkedListMember<T>(item)
                    { NextItem = nextListMember, PreviousItem = prevListMember };
                prevListMember.NextItem = insertedListMember;
                if (nextListMember != null) nextListMember.PreviousItem = insertedListMember; //possible null reference
            }
            else
            {
                LinkedListMember<T> nextListMember = GetListMemberAt(index);
                insertedListMember = new DoublyLinkedListMember<T>(item)
                    { NextItem = nextListMember, PreviousItem = null };
                FirstListMember = insertedListMember;
            }

            LastElementIndex++;
            Data[LastElementIndex] = insertedListMember;
        }

        public override void Reverse() //recheck
        {
            LinkedListMember<T> lastListMember = GetListMemberAt(LastElementIndex);

            for (int i = LastElementIndex; i >= 0; i--)
            {
                DoublyLinkedListMember<T> currentListMember = (DoublyLinkedListMember<T>)GetListMemberAt(i);
                (currentListMember.PreviousItem, currentListMember.NextItem) =
                    (currentListMember.NextItem, currentListMember.PreviousItem);
            }

            FirstListMember = lastListMember;
        }
    }
}
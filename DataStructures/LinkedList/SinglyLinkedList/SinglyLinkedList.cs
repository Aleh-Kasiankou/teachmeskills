namespace LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : LinkedList<T>
    {
        public SinglyLinkedList(T[] array) : base(array)
        {
        }

        protected override void InsertFirstListMember(T value)
        {
            {
                Head = new LinkedListMember<T>(value) { NextItem = Head };
            }
        }

        protected override void InsertNonMarginalElement(int index, T value)
        {
            LinkedListMember<T> prevListMember = GetListMemberAt(index - 1);
            LinkedListMember<T> nextListMember = prevListMember.NextItem;

            var insertedListMember = new LinkedListMember<T>(value) { NextItem = nextListMember };
            prevListMember.NextItem = insertedListMember;
        }

        protected override void InsertLastListMember(T value)
        {
            {
                Tail.NextItem = new LinkedListMember<T>(value);
                Tail = Tail.NextItem;
            }
        }

        public override void Reverse()
        {
            for (int i = LastElementIndex; i >= 1; i--)
            {
                LinkedListMember<T> prevListMember = GetListMemberAt(i - 1);
                LinkedListMember<T> currentListMember = GetListMemberAt(i);
                currentListMember.NextItem = prevListMember;
            }

            Head.NextItem = null;
            (Head, Tail) = (Tail, Head);
        }
    }
}
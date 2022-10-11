using System;

namespace LinkedList.SinglyLinkedList
{
    public class SinglyLinkedCircularList<T> : LinkedList<T>
    {
        public SinglyLinkedCircularList(int size = 16) : base(size)
        {
        }
        
        public SinglyLinkedCircularList(T[] array) : base(array)
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
                LinkedListMember<T> nextListMember = prevListMember.NextItem;

                insertedListMember = new LinkedListMember<T>(item) { NextItem = nextListMember };
                prevListMember.NextItem = insertedListMember;
            }
            else
            {
                LinkedListMember<T> nextListMember = GetListMemberAt(index);
                insertedListMember = new LinkedListMember<T>(item) { NextItem = nextListMember };
                FirstListMember = insertedListMember;
            }
            
            LastElementIndex++;
            if (insertedListMember.NextItem is null)
            {
                insertedListMember.NextItem = FirstListMember;
            }

            Data[LastElementIndex] = insertedListMember;
        }

        public override void Reverse()
        {
            LinkedListMember<T> lastListMember = GetListMemberAt(LastElementIndex);

            for (int i = LastElementIndex; i >= 1; i--)
            {
                LinkedListMember<T> prevListMember = GetListMemberAt(i - 1);
                LinkedListMember<T> currentListMember = GetListMemberAt(i);
                currentListMember.NextItem = prevListMember;
            }

            FirstListMember.NextItem = lastListMember;
            FirstListMember = lastListMember;
        }
    }
}
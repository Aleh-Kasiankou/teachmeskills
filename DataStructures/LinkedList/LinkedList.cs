using System;
using System.Text;

namespace LinkedList
{
    public abstract class LinkedList<T> : ILinkedList<T>
    {
        protected LinkedListMember<T> Head { get; set; }
        protected LinkedListMember<T> Tail { get; set; }
        protected int LastElementIndex { get; private set; } = -1;
        
        protected LinkedList(T[] array)
        {
            foreach (var el in array)
            {
                Add(el);
            }
        }

        public void Add(T item)
        {
            Insert(item, LastElementIndex + 1);
        }


        public virtual void RemoveAt(int index)
        {
            ValidateIndex(index);

            LinkedListMember<T> memberToRemove = GetListMemberAt(index);

            if (index > 0)
            {
                LinkedListMember<T> previousListMember = GetListMemberAt(index - 1);
                previousListMember.NextItem = memberToRemove.NextItem;
            }

            if (index == 0)
            {
                Head = Head.NextItem;
            }

            LastElementIndex--;
        }

        public virtual T GetElementAt(int index)
        {
            ValidateIndex(index);
            var currentListMember = GetListMemberAt(index);
            return currentListMember.Value;
        }

        public void Insert(T item, int index)
        {
            if (index > 0 && index <= LastElementIndex)
            {
                InsertNonMarginalElement(index, item);
            }
            
            else if (index == 0)
            {
                InsertFirstListMember(item);
                if (LastElementIndex == -1)
                {
                    Tail = Head;
                }
            }

            else if (index == LastElementIndex + 1)
            {
                InsertLastListMember(item);
            }
            
            else
            {
                throw new IndexOutOfRangeException();
            }

            LastElementIndex++;
        }

        public abstract void Reverse();

        private void ValidateIndex(int index)
        {
            if (index > LastElementIndex ||
                index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        protected abstract void InsertFirstListMember(T value);

        protected abstract void InsertNonMarginalElement(int index, T value);

        protected abstract void InsertLastListMember(T value);
        
        protected LinkedListMember<T> GetListMemberAt(int index)
        {
            ValidateIndex(index);

            LinkedListMember<T> currentListMember = Head;
            for (int i = 1; i <= index; i++)
            {
                currentListMember = currentListMember.NextItem;
            }

            return currentListMember;
        }

        public override string ToString()
        {
            var stringRepresentation = new StringBuilder("{" + Head.Value.ToString());
            LinkedListMember<T> listMember = Head;
            for (int i = 0; i < LastElementIndex; i++)
            {
                stringRepresentation.Append(", ");
                stringRepresentation.Append(listMember.NextItem.Value);
                listMember = listMember.NextItem;
            }

            stringRepresentation.Append("}");

            return stringRepresentation.ToString();
        }
    }
}
using System;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public abstract class LinkedList<T> : ILinkedList<T>
    {
        protected LinkedListMember<T>[] Data { get; private set; }

        protected LinkedListMember<T> FirstListMember { get; set; }
        protected int LastElementIndex { get; set; } = -1;

        protected LinkedList(int size = 16)
        {
            Data = new LinkedListMember<T>[size];
            FirstListMember = Data[0];
        }

        protected LinkedList(T[] array)
        {
            Data = new LinkedListMember<T>[array.Length];
            foreach (var el in array)
            {
                Add(el);
            }

            FirstListMember = Data[0];
        }

        public virtual void Add(T item)
        {
            Insert(item, LastElementIndex + 1);
        }

        // Decreases size of Data by one
        public virtual void RemoveAt(int index)
        {
            ValidateIndex(index);

            LinkedListMember<T> memberToRemove = GetListMemberAt(index);
            
            Data = Data.Where(val => val != memberToRemove).ToArray();

            if (index > 0)
            {
                LinkedListMember<T> memberToUpdate = GetListMemberAt(index - 1);
                memberToUpdate.NextItem = memberToRemove.NextItem;
            }
            
            if (index == 0)
            {
                FirstListMember = FirstListMember.NextItem;
            }

            LastElementIndex--;
        }

        public virtual T GetElementAt(int index)
        {
            var currentListMember = GetListMemberAt(index);
            return currentListMember.Value;
        }

        public abstract void Insert(T item, int index);

        public abstract void Reverse();

        protected void ValidateIndex(int index)
        {
            if (index >= Data.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        protected void AdjustSize(int requiredIndex)
        {
            if (requiredIndex >= Data.Length)
            {
                var newSize = Data.Length * 2;
                LinkedListMember<T>[] newData = new LinkedListMember<T>[newSize];
                Data.CopyTo(newData, 0);
                Data = newData;
            }
        }

        protected virtual LinkedListMember<T> GetListMemberAt(int index)
        {
            ValidateIndex(index);

            LinkedListMember<T> currentListMember = FirstListMember;
            for (int i = 1; i <= index; i++)
            {
                currentListMember = currentListMember.NextItem;
            }

            return currentListMember;
        }

        public override string ToString()
        {
            var stringRepresentation = new StringBuilder("{" + FirstListMember.Value.ToString());
            LinkedListMember<T> listMember = FirstListMember;
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
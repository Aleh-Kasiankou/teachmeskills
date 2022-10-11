namespace LinkedList
{
    public interface ILinkedList<T>
    {
        public void Add(T item);

        public void RemoveAt(int index);

        public T GetElementAt(int index);

        public void Insert(T item, int index);

        public void Reverse();
        
    }
}
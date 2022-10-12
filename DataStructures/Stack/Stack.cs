using System;
using System.Text;

namespace Stack
{
    public class Stack<T>: IStack<T>
    {
        public Stack()
        {
            
        }

        public Stack(T[] array)
        {
            foreach (var value in array)
            {
                Push(value);
            }
        }

        private StackItem<T> Tail { get; set; }
        
        public void Push(T value)
        {
            Tail = new StackItem<T>(value) { PreviousItem = Tail };
        }

        public T Pop()
        {
            var lastElement = Tail ?? throw new IndexOutOfRangeException();
            Tail = Tail.PreviousItem;
            return lastElement.Value;
        }

        public void Clean()
        {
            Tail = null;
        }

        public override string ToString()
        {
            StringBuilder stringRepresentation = new StringBuilder();
            var currentElement = Tail;
            if (currentElement is null)
            {
                stringRepresentation.Append("The stack is empty");
            }

            else
            {
                stringRepresentation.Append("{");
                while (!(currentElement is null))
                {
                    stringRepresentation.Append(" <" + currentElement.Value);
                    currentElement = currentElement.PreviousItem;
                }
                stringRepresentation.Append("}");
            }

            return stringRepresentation.ToString();
        }
    }
}
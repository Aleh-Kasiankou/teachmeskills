using System;
using System.Text;

namespace Queue
{
    public class Queue<T> : IQueue<T>
    {
        private QueueMember<T> Head { get; set; }
        private QueueMember<T> Tail { get; set; }

        public Queue()
        {
        }

        public Queue(T[] array)
        {
            foreach (var item in array)
            {
                Enqueue(item);
            }
        }

        public void Enqueue(T value)
        {
            var newQueueMember = new QueueMember<T>(value);
            if (Tail is null)
            {
                Tail = newQueueMember;
                Head = newQueueMember;
            }

            else
            {
                Tail.FollowingMember = newQueueMember;
                Tail = newQueueMember;
            }
        }

        public T Dequeue()
        {
            var itemToDequeue = Head ?? throw new IndexOutOfRangeException();
            Head = Head.FollowingMember;
            return itemToDequeue.Value;
        }

        public override string ToString()
        {
            StringBuilder stringRepresentation = new StringBuilder();
            var currentElement = Head;
            if (currentElement is null)
            {
                stringRepresentation.Append("The queue is empty");
            }

            else
            {
                stringRepresentation.Append("{");
                while (!(currentElement is null))
                {
                    stringRepresentation.Append(" <" + currentElement.Value);
                    currentElement = currentElement.FollowingMember;
                }

                stringRepresentation.Append("}");
            }

            return stringRepresentation.ToString();
        }
    }
}
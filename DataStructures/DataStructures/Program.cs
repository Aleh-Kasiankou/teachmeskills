using System;
using LinkedList.DoublyLinkedList;
using LinkedList.SinglyLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var testList = new DoublyLinkedList<int>(new[] { 1, 2, 3, 4 });
            Console.WriteLine(testList.ToString());
            testList.Insert(228, 0);
            testList.Insert(229, 1);
            Console.WriteLine(testList.ToString());
            testList.Reverse();
            Console.WriteLine(testList.ToString());

            for (int i = 0; i < 20; i++)
            {
                testList.Add(i);
            }

            Console.WriteLine(testList.ToString());
            testList.Reverse();
            Console.WriteLine(testList.ToString());
            // testList.Insert(25, 100);
        }
    }
}
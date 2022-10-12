﻿using System;
using LinkedList.DoublyLinkedList;
using LinkedList.SinglyLinkedList;
using Queue;
using Stack;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestLinkedList();
            // TestStack();
            TestQueue();
        }

        internal static void TestLinkedList()
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

        internal static void TestStack()
        {
            // var testStack = new Stack<int>(new[] { 1, 2, 3, 4 });
            var testStack = new Stack<int>();
            Console.WriteLine(testStack);
            testStack.Push(5);
            Console.WriteLine(testStack);
            testStack.Push(6);
            
            Console.WriteLine(testStack);
            Console.WriteLine(testStack.Pop());
            Console.WriteLine(testStack);
            Console.WriteLine(testStack.Pop());
            Console.WriteLine(testStack);
            testStack.Push(6);
            testStack.Clean();
            Console.WriteLine(testStack);
            // Console.WriteLine(testStack.Pop());
        }

        internal static void TestQueue()
        {
            // var testQueue = new Queue<int>(new[] { 1, 2, 3, 4 });
            var testQueue = new Queue<int>();
            Console.WriteLine(testQueue);
            testQueue.Enqueue(5);
            Console.WriteLine(testQueue);
            testQueue.Enqueue(6);
            
            Console.WriteLine(testQueue);
            Console.WriteLine(testQueue.Dequeue());
            Console.WriteLine(testQueue);
            Console.WriteLine(testQueue.Dequeue());
            Console.WriteLine(testQueue);
            // Console.WriteLine(testQueue.Dequeue());
            // Console.WriteLine(testQueue);
        }

    }
}
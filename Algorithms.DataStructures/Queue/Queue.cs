using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.Queue
{
    public class Queue<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public bool IsEmpty => Last == null;

        public void Enqueue(T value)
        {
            var node = new Node<T>(value);

            if (IsEmpty)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = Last.Next;
            }
        }

        public void Dequeue()
        {
            First = First.Next;

            if (First == null)
                Last = null;
        }

        public T Peek()
        {
            if (IsEmpty)
                return default(T);

            return First.Value;
        }
        public void Print()
        {
            if (IsEmpty)
                return;

            var current = First;
            while (current.Next != null)
            {
                Console.Write($"{current.Value} --> ");
                current = current.Next;
            }

            Console.WriteLine($"{current.Value}\n");
        }
    }


}

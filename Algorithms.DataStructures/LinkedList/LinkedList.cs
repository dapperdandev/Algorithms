using System;

namespace Algorithms.DataStructures.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public Node<T> GetLastNode()
        {
            if (IsEmpty)
                return null;

            return Enumerate();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddFirst(T value)
        {
            var node = new Node<T>(value);
            var temp = Head;

            Head = node;

            if (IsEmpty)
                Tail = Head;
            else
                temp.Previous = Head;
                Head.Next = temp;

            Count++;

        }

        public void AddLast(T value)
        {
            var node = new Node<T>(value);

            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                return;

            Head = Head.Next;
            Count--;

            if (IsEmpty)
                Tail = null;
            else
                Head.Previous = null;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
                return;

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }

            Count--;
        }

        public Node<T> Find(T value)
        {
            var current = Head;
            while (current.Next != null)
            {
                if (current.Value.Equals(value))
                    return current;

                current = current.Next;
            }

            return null;
        }

        public void Print()
        {
            if (IsEmpty)
                return;

            var current = Head;
            while (current.Next != null)
            {
                Console.Write($"{current.Value} <--> ");
                current = current.Next;
            }

            Console.Write($"{current.Value}\n");
        }

        private Node<T> Enumerate()
        {
            var current = Head;
            while (current.Next != Tail)
                current = current.Next;

            return current;
        }
    }
}

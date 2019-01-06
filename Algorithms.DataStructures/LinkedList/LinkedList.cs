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
            /**
             * Store Head in a temporary variable
             * Create a new node and assign it to Head
             * Assign the temporary variable to Head.Next
             * Assign Head to temp.Previous or assign Tail
             * Update Tail
             */

            var node = new Node<T>(value);  
            var temp = Head;

            Head = node; 
            Head.Next = temp;

            if (IsEmpty)
                Tail = Head;
            else
                temp.Previous = Head;

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

        public void AddAfter(T target, T toInsert)
        {
            if (IsEmpty)
                return;

            var prevNode = Find(target);

            if (prevNode == null)
                return;

            var nextNode = prevNode.Next;
            var node = new Node<T>(toInsert);

            node.Previous = prevNode;
            node.Next = nextNode;

            prevNode.Next = node;

            if (nextNode == null)
                Tail = node;
            else
                nextNode.Previous = node;

            Count++;
        }

        public void AddBefore(T target, T toInsert)
        {
            if (IsEmpty)
                return;

            var nextNode = Find(target);

            if (nextNode == null)
                return;

            var prevNode = nextNode.Previous;
            var node = new Node<T>(toInsert);

            node.Previous = prevNode;
            node.Next = nextNode;

            nextNode.Previous = node;

            if (prevNode == null)
                Head = node;
            else
                prevNode.Next = node;

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

        public void RemoveBefore(T value)
        {
            if (IsEmpty)
                return;

            var nextNode = Find(value);

            if (nextNode?.Previous == null)
                return;

            var target = nextNode.Previous;
            var prevNode = target.Previous;

            nextNode.Previous = prevNode;

            if (nextNode.Previous == null)
                Head = nextNode;
            else
                prevNode.Next = nextNode;

            Count--;
        }

        public void RemoveAfter(T value)
        {
            if (IsEmpty)
                return;

            var prevNode = Find(value);

            if (prevNode?.Next == null)
                return;

            var target = prevNode.Next;
            var nextNode = target.Next;

            prevNode.Next = nextNode;

            if (prevNode.Next == null)
                Tail = prevNode;
            else
                nextNode.Previous = prevNode;

            Count--;
        }

        public Node<T> Find(T value)
        {
            var current = Head;
            while (current != null)
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
            while (current != Tail)
                current = current.Next;

            return current;
        }
    }
}

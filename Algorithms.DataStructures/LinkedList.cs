using System;

namespace Algorithms.DataStructures
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public int Size()
        {
            var current = Head;
            var count = 0;

            while (current != null)
            {
                count += 1;
                current = current.Next;
            }

            return count;
        }

        public Node<T> GetLastNode()
        {
            if(Head != null)
            {
                Node<T> temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;

                return temp;
            }

            return null;
        }

        public void AddToEnd(Node<T> node)
        {
            if (Head != null)
            {
                Node<T> lastNode = GetLastNode();
                lastNode.Next = node;
            }
            else
            {
                Head = node;
            }
        }
    }
}

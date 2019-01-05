using System;

namespace Algorithms.DataStructures.BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node<T> Head { get; private set; }
        public int Count { get; private set; }

        public void Add(T value)
        {
            var node = new Node<T>(value);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                AddTo(Head, node);
            }
        }

        public void AddTo(Node<T> parent, Node<T> child)
        {
            if (child.Value.CompareTo(parent.Value) < 0)
            {
                if (parent.LeftChild == null)
                    parent.LeftChild = child;
                else
                    AddTo(parent.LeftChild, child);     
            }
            else
            {
                if (parent.RightChild == null)
                    parent.RightChild = child;
                else
                    AddTo(parent.RightChild, child);    
            }
        }
    }
}

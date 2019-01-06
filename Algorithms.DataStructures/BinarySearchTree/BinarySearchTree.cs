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
                Head = node;
            else
                AddTo(Head, node);

            Count++;
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

        public bool Contains(T value)
        {
            Node<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        public Node<T> FindWithParent(T value, out Node<T> parent)
        {
            var current = Head;
            parent = null;

            while (current != null)
            {
                var result = current.CompareTo(value);

                if (result > 0)
                {
                    parent = current;
                    current = current.LeftChild;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.RightChild;
                }
                else
                {
                    break;
                }
            }

            return current;
        }
    }
}

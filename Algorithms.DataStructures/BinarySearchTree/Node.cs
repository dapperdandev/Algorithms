using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.BinarySearchTree
{
    public class Node<T> : IComparable<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }

        public Node(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}

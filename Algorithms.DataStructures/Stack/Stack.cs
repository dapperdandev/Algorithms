using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace Algorithms.DataStructures.Stack
{
    public class Stack<T>
    {
        public Node<T> Top { get; private set; }
        public bool IsEmpty => Top == null;

        public void Push(T value)
        {
            var node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        public void Pop()
        {
            /**
             * Some implementations return a value. This implementation follows the principle of
             * "Don't pay for what you don't need"
             */

            if (IsEmpty)
                return;

            Top = Top.Next;
        }

        public T Peek()
        {
            if (IsEmpty)
                return default(T);

            return Top.Value;
        }

        public void Print()
        {
            if (IsEmpty)
                return;

            var current = Top;
            while (current.Next != null)
            {
                Console.WriteLine(current.Value);
                Console.WriteLine(@"|");
                current = current.Next;
            }

            Console.WriteLine(current.Value);
        }
    }
}

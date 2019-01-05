namespace Algorithms.DataStructures.LinkedList
{
    public class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node (T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }

    }
}

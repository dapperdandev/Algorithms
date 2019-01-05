namespace Algorithms.DataStructures.Stack
{
    public class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}

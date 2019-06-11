namespace Algorithms.DataStructures.BinarySearchTree
{
    public class BinarySearchTree<T>
    {
        public Node Root { get; private set; }
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (IsEmpty)
            {
                Root = newNode;
            }
            else
            {
                Node currentNode = Root;
                bool isAdded = false;
                while (!isAdded)
                {
                    if (value < currentNode.Value)
                    {
                        if (currentNode.LeftChild == null)
                        {
                            currentNode.LeftChild = newNode;
                            isAdded = true;
                        }

                        currentNode = currentNode.LeftChild;
                    }
                    else
                    {
                        if (currentNode.RightChild == null)
                        {
                            currentNode.RightChild = newNode;
                            isAdded = true;
                        }

                        currentNode = currentNode.RightChild;
                    }
                }
            }

            Count++;
        }

        public void InsertRecursive(int value)
        {
            Root = InsertRecursive(Root, value);
            Count++;
        }

        private Node InsertRecursive(Node current, int value)
        {
            Node newNode = new Node(value);

            if (current == null)
                return newNode;

            if (value < current.Value)
                current.LeftChild = InsertRecursive(current.LeftChild, value);
            else
                current.RightChild = InsertRecursive(current.RightChild, value);

            return current;

        }
    }
}
using System;

namespace Algorithms.DataStructures.BST
{
    public class BinarySearchTree
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

        public Node Find(int value)
        {
            return Find(Root, value);
        }

        public Node Find(Node current, int value)
        {
            if (current == null)
                return null;

            else if (current.Value == value)
                return current;

            else if (value < current.Value)
                return Find(current.LeftChild, value);

            return Find(current.RightChild, value);
        }

        public Node FindWithParent(int value, out Node parent)
        {
            Node current = Root;
            parent = null;

            while (current != null)
            {
                if (value < current.Value)
                {
                    parent = current;
                    current = current.LeftChild;
                }
                else if (value > current.Value)
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


        public Node GetMin()
        {
            return GetMin(Root);
        }

        private Node GetMin(Node node)
        {
            if (node?.LeftChild == null)
                return node;

            return GetMin(node.LeftChild);
        }


        public void PreOrderTraversal(Action<int> action)
        {
            PreOrderTraversal(action, Root);
        }
        private void PreOrderTraversal(Action<int> action, Node node)
        {
            if (node != null)
            {
                action(node.Value);
                PreOrderTraversal(action, node.LeftChild);
                PreOrderTraversal(action, node.RightChild);
            }
        }

        public void InOrderTraversal(Action<int> action)
        {
            InOrderTraversal(action, Root);
        }

        private void InOrderTraversal(Action<int> action, Node node)
        {
            if (node != null)
            {
                InOrderTraversal(action, node.LeftChild);
                action(node.Value);
                InOrderTraversal(action, node.RightChild);
            }
        }

        public void PostOrderTraversal(Action<int> action)
        {
            PostOrderTraversal(action, Root);
        }

        private void PostOrderTraversal(Action<int> action, Node node)
        {
            if (node != null)
            {
                PostOrderTraversal(action,node.LeftChild);
                PostOrderTraversal(action, node.RightChild);
                action(node.Value);
            }
        }
        public void Remove(int value)
        {
            Remove(Root, value);
        }

        private Node Remove(Node node, int value)
        {
            if (node == null)
                return node;
            if (value < node.Value)
                node.LeftChild = Remove(node.LeftChild, value);
            else if (value > node.Value)
                node.RightChild = Remove(node.RightChild, value);
            else
                if (node.LeftChild == null)
                return node.RightChild;
            else if (node.RightChild == null)
                return node.LeftChild;
            else
            {
                node = GetMin(node.RightChild);
                node.RightChild = Remove(node.RightChild, node.Value);
            }


            return node;

        }
    }
}
using Algorithms.DataStructures.BST;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.DataStructures.Tests
{
    [TestFixture, Parallelizable]
    public class BinarySearchTreeTests
    {
        private List<int> _values;
        private BinarySearchTree _binarySearchTree;

        [SetUp]
        public void Setup()
        {
            _values = new List<int> { 8, 4, 2, 6, 10, 20 };
            _binarySearchTree = new BinarySearchTree();

            /*
             *                8
             *            4      10
             *          2   6        20
             */
        }

        [Test]
        public void Insert_ArrangesNodesCorrectly()
        {
            _values.ForEach(val => _binarySearchTree.Insert(val));

            Assert.AreEqual(_values[0], _binarySearchTree.Root.Value);
            Assert.AreEqual(_values[1], _binarySearchTree.Root.LeftChild.Value);
            Assert.AreEqual(_values[2], _binarySearchTree.Root.LeftChild.LeftChild.Value);
            Assert.AreEqual(_values[3], _binarySearchTree.Root.LeftChild.RightChild.Value);
            Assert.AreEqual(_values[4], _binarySearchTree.Root.RightChild.Value);
            Assert.AreEqual(_values[5], _binarySearchTree.Root.RightChild.RightChild.Value);
            Assert.AreEqual(_values.Count, _binarySearchTree.Count);
        }

        [Test]
        public void InsertRecursive_ArrangesNodesCorrectly()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));

            Assert.AreEqual(_values[0], _binarySearchTree.Root.Value);
            Assert.AreEqual(_values[1], _binarySearchTree.Root.LeftChild.Value);
            Assert.AreEqual(_values[2], _binarySearchTree.Root.LeftChild.LeftChild.Value);
            Assert.AreEqual(_values[3], _binarySearchTree.Root.LeftChild.RightChild.Value);
            Assert.AreEqual(_values[4], _binarySearchTree.Root.RightChild.Value);
            Assert.AreEqual(_values[5], _binarySearchTree.Root.RightChild.RightChild.Value);
            Assert.AreEqual(_values.Count, _binarySearchTree.Count);
        }

        [Test]
        public void Find_FindsNode()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));

            Node node = _binarySearchTree.Find(4);

            Assert.AreEqual(node.Value, 4);
            Assert.AreEqual(node.LeftChild.Value, 2);
            Assert.AreEqual(node.RightChild.Value, 6);
        }

        [Test]
        public void FindWithParent_FindsNode()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));

            Node parent;
            var node = _binarySearchTree.FindWithParent(4, out parent);

            Assert.AreEqual(node.Value, 4);
            Assert.AreEqual(node.LeftChild.Value, 2);
            Assert.AreEqual(node.RightChild.Value, 6);
            Assert.AreEqual(parent.Value, 8);
        }

        [Test]
        public void GetMin_FindsMinimum()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));
            var sortedValues = _values.OrderBy(x => x).ToList();

            var min = _binarySearchTree.GetMin();

            Assert.AreEqual(sortedValues[0], min.Value);
        }

        [Test]
        public void PreOrderTraversal_TraversesTreeInCorrectOrder()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));
            var expected = new List<int> { 8, 4, 2, 6, 10, 20 };
            var result = new List<int>();
            Action<int> action = (val) => result.Add(val);

            _binarySearchTree.PreOrderTraversal(action);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void InOrderTraversal_TraversesTreeInCorrectOrder()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));
            var expected = new List<int> { 2, 4, 6, 8, 10, 20 };
            var result = new List<int>();
            Action<int> action = (val) => result.Add(val);

            _binarySearchTree.InOrderTraversal(action);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void PostOrderTraversal_TraversesTreeInCorrectOrder()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));
            var expected = new List<int> { 2, 6, 4, 20, 10, 8 };
            var result = new List<int>();
            Action<int> action = (val) => result.Add(val);

            _binarySearchTree.PostOrderTraversal(action);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Remove_RemovesNode()
        {
            _values.ForEach(val => _binarySearchTree.InsertRecursive(val));
            var sortedValues = _values.OrderBy(x => x).ToList();

            _binarySearchTree.Remove(20);

            Assert.AreEqual(null, _binarySearchTree.Find(20));
        }
    }
}

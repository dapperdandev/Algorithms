using Algorithms.DataStructures.BinarySearchTree;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.DataStructures.Tests
{
    [TestFixture, Parallelizable]
    public class BinarySearchTreeTests
    {
        private BinarySearchTree<int> _binarySearchTree;

        [SetUp]
        public void Setup()
        {
            _binarySearchTree = new BinarySearchTree<int>();
        }

        [Test]
        public void Insert_ArrangesNodesCorrectly()
        {
            List<int> values = new List<int> { 8, 4, 2, 6, 10, 20 };
            /*
             *                8
             *            4      10
             *          2   6        20
             */
            values.ForEach(val => _binarySearchTree.Insert(val));

            Assert.AreEqual(values[0], _binarySearchTree.Root.Value);
            Assert.AreEqual(values[1], _binarySearchTree.Root.LeftChild.Value);
            Assert.AreEqual(values[2], _binarySearchTree.Root.LeftChild.LeftChild.Value);
            Assert.AreEqual(values[3], _binarySearchTree.Root.LeftChild.RightChild.Value);
            Assert.AreEqual(values[4], _binarySearchTree.Root.RightChild.Value);
            Assert.AreEqual(values[5], _binarySearchTree.Root.RightChild.RightChild.Value);
            Assert.AreEqual(values.Count, _binarySearchTree.Count);
        }

        [Test]
        public void InsertRecursive_ArrangesNodesCorrectly()
        {
            List<int> values = new List<int> { 8, 4, 2, 6, 10, 20 };
            /*
             *                8
             *            4      10
             *          2   6        20
             */
            values.ForEach(val => _binarySearchTree.InsertRecursive(val));

            Assert.AreEqual(values[0], _binarySearchTree.Root.Value);
            Assert.AreEqual(values[1], _binarySearchTree.Root.LeftChild.Value);
            Assert.AreEqual(values[2], _binarySearchTree.Root.LeftChild.LeftChild.Value);
            Assert.AreEqual(values[3], _binarySearchTree.Root.LeftChild.RightChild.Value);
            Assert.AreEqual(values[4], _binarySearchTree.Root.RightChild.Value);
            Assert.AreEqual(values[5], _binarySearchTree.Root.RightChild.RightChild.Value);
            Assert.AreEqual(values.Count, _binarySearchTree.Count);
        }
    }
}
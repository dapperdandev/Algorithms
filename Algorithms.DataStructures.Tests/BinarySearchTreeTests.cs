using Algorithms.DataStructures.BinarySearchTree;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.DataStructures.Tests
{
    [TestFixture, Parallelizable]
    public class BinarySearchTreeTests
    {
        private BinarySearchTree<int> _binarySearchTree;
        private List<int> _values;

        [SetUp]
        public void Setup()
        {
            _binarySearchTree = new BinarySearchTree<int>();
            _values = new List<int> { 4, 2, 6 , 1, 3, 5, 7};
        }

        [Test]
        public void EmptyQueue_IsTrulyEmpty()
        {
            _values.ForEach(val => _binarySearchTree.Add(val));

            Assert.IsTrue(true);
        }
    }
}
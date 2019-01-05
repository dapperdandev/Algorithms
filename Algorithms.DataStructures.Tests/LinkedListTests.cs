using Algorithms.DataStructures.LinkedList;
using NUnit.Framework;

namespace Algorithms.DataStructures.Tests
{
    [TestFixture, Parallelizable]
    public class LinkedListTests
    {
        private LinkedList<int> _linkedList;

        [SetUp]
        public void Setup()
        {
            _linkedList = new LinkedList<int>();
        }

        [TestCase(1, 2, 3)]
        public void Clear_IsEmpty(int first, int second, int third)
        {
            _linkedList.AddFirst(first);
            _linkedList.AddFirst(second);
            _linkedList.AddFirst(third);

            _linkedList.Clear();

            Assert.AreEqual(_linkedList.Count, 0);
            Assert.IsTrue(_linkedList.IsEmpty);
        }

        [TestCase(1, 2, 3)]
        public void Count_IsAccurate(int first, int second, int third)
        {
            _linkedList.AddFirst(first);
            _linkedList.AddFirst(second);
            _linkedList.AddFirst(third);
            _linkedList.AddLast(second);
            _linkedList.AddLast(first);

            Assert.AreEqual(_linkedList.Count, 5);
        }

        [TestCase(1,2,3)]
        public void AddFirst_HasPointers(int first, int second, int third)
        {
            _linkedList.AddFirst(first);
            _linkedList.AddFirst(second);
            _linkedList.AddFirst(third);

            Assert.AreEqual(_linkedList.Tail.Value, first);
            Assert.AreEqual(_linkedList.Head.Value, third);
            Assert.AreEqual(_linkedList.Head.Next.Value, second);
            Assert.AreEqual(_linkedList.Tail.Previous.Value, second);
        }

        [TestCase(1, 2, 3)]
        public void RemoveFirst_RemovesPreviousFromNewHead(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);
            _linkedList.RemoveFirst();

            Assert.AreEqual(_linkedList.Head.Value, second);
            Assert.AreEqual(_linkedList.Head.Previous, null);
        }

        [TestCase(1, 2, 3)]
        public void RemoveLast_FunctionsCorrectly(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);

            _linkedList.RemoveLast();

            Assert.AreEqual(_linkedList.Tail.Value, second);
        }

        [TestCase(1, 2, 3)]
        public void Print_Prints(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);

            _linkedList.Print();
        }

        [TestCase(1, 2, 3)]
        public void Find_ReturnsNullOnNoResult(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);

            Assert.AreEqual(_linkedList.Find(7), null);
        }
    }
}
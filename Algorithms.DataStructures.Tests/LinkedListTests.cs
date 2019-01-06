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
        public void InsertAfter_ListWithOneNode_HasPointers(int first, int second, int third)
        {
            _linkedList.AddFirst(first);
            _linkedList.AddAfter(first, second);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Tail.Value, second);
            Assert.AreEqual(_linkedList.Head.Next.Value, second);
            Assert.AreEqual(_linkedList.Tail.Previous.Value, first);
        }

        [TestCase(1, 2, 3, 4)]
        public void InsertAfter_ListWithManyNodes_HasPointers(int first, int second, int third, int fourth)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);
            _linkedList.AddAfter(second, fourth);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Head.Next.Next.Value, fourth);
            Assert.AreEqual(_linkedList.Head.Next.Value, second);
            Assert.AreEqual(_linkedList.Tail.Previous.Value, fourth);
            Assert.AreEqual(_linkedList.Tail.Value, third);
        }

        [TestCase(1, 2, 3)]
        public void InsertAfter_EmptyList_DoesNothing(int first, int second, int third)
        {
            _linkedList.AddAfter(first, second);

            Assert.IsNull(_linkedList.Head);
            Assert.IsNull(_linkedList.Tail);
            Assert.IsTrue(_linkedList.IsEmpty);
        }

        [TestCase(1, 2, 3)]
        public void InsertAfter_InvalidNode_DoesNothing(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddAfter(third, third);

            var result = _linkedList.Find(third);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Tail.Value, second);
            Assert.IsNull(result);
        }

        [TestCase(1, 2, 3)]
        public void InsertBefore_ListWithOneNode_HasPointers(int first, int second, int third)
        {
            _linkedList.AddFirst(first);
            _linkedList.AddBefore(first, second);

            Assert.AreEqual(_linkedList.Head.Value, second);
            Assert.AreEqual(_linkedList.Tail.Value, first);
            Assert.AreEqual(_linkedList.Head.Next.Value, first);
            Assert.AreEqual(_linkedList.Tail.Previous.Value, second);
        }

        [TestCase(1, 2, 3, 4)]
        public void InsertBefore_ListWithManyNodes_HasPointers(int first, int second, int third, int fourth)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);
            _linkedList.AddBefore(third, fourth);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Head.Next.Next.Value, fourth);
            Assert.AreEqual(_linkedList.Head.Next.Value, second);
            Assert.AreEqual(_linkedList.Tail.Previous.Value, fourth);
            Assert.AreEqual(_linkedList.Tail.Value, third);
        }

        [TestCase(1, 2, 3)]
        public void InsertBefore_EmptyList_DoesNothing(int first, int second, int third)
        {
            _linkedList.AddBefore(first, second);

            Assert.IsNull(_linkedList.Head);
            Assert.IsNull(_linkedList.Tail);
            Assert.IsTrue(_linkedList.IsEmpty);
        }

        [TestCase(1, 2, 3)]
        public void InsertBefore_InvalidNode_DoesNothing(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddBefore(third, third);

            var result = _linkedList.Find(third);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Tail.Value, second);
            Assert.IsNull(result);
        }

        [TestCase(1, 2, 3)]
        public void RemoveFirst_RemovesPreviousFromNewHead(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);
            _linkedList.RemoveFirst();

            Assert.AreEqual(_linkedList.Head.Value, second);
            Assert.IsNull(_linkedList.Head.Previous);
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
        public void RemoveBefore_ListWithMultipleNodes_RemovesCorrectNode(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);
            _linkedList.RemoveBefore(third);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Tail.Value, third);
            Assert.AreEqual(_linkedList.Head.Next.Value, third);
            Assert.AreEqual(_linkedList.Tail.Previous.Value, first);
        }

        [TestCase(1, 2, 3)]
        public void RemoveBefore_ListWithZeroNodes_DoesNothing(int first, int second, int third)
        {
            _linkedList.RemoveBefore(third);

            Assert.IsNull(_linkedList.Head);
            Assert.IsNull(_linkedList.Tail);
            Assert.IsTrue(_linkedList.IsEmpty);

        }

        [TestCase(1, 2, 3)]
        public void RemoveBefore_ListWithOneNode_DoesNothing(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.RemoveBefore(first);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Tail.Value, first);
            Assert.IsNull(_linkedList.Head.Next);
            Assert.IsNull(_linkedList.Tail.Next);

        }

        [TestCase(1, 2, 3)]
        public void RemoveAfter_ListWithMultipleNodes_RemovesCorrectNode(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.AddLast(second);
            _linkedList.AddLast(third);
            _linkedList.RemoveAfter(first);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Tail.Value, third);
            Assert.AreEqual(_linkedList.Head.Next.Value, third);
            Assert.AreEqual(_linkedList.Tail.Previous.Value, first);
        }

        [TestCase(1, 2, 3)]
        public void RemoveAfter_ListWithZeroNodes_DoesNothing(int first, int second, int third)
        {
            _linkedList.RemoveAfter(third);

            Assert.IsNull(_linkedList.Head);
            Assert.IsNull(_linkedList.Tail);
            Assert.IsTrue(_linkedList.IsEmpty);

        }

        [TestCase(1, 2, 3)]
        public void RemoveAfter_ListWithOneNode_DoesNothing(int first, int second, int third)
        {
            _linkedList.AddLast(first);
            _linkedList.RemoveAfter(first);

            Assert.AreEqual(_linkedList.Head.Value, first);
            Assert.AreEqual(_linkedList.Tail.Value, first);
            Assert.IsNull(_linkedList.Head.Next);
            Assert.IsNull(_linkedList.Tail.Next);

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

            Assert.IsNull(_linkedList.Find(7));
        }
    }
}
using Algorithms.DataStructures.Queue;
using NUnit.Framework;

namespace Algorithms.DataStructures.Tests
{
    [TestFixture, Parallelizable]
    public class QueueTests
    {
        private Queue<int> _intQueue;

        [SetUp]
        public void Setup()
        {
            _intQueue = new Queue<int>();
        }

        [TestCase(1, 2, 3)]
        public void EmptyQueue_IsTrulyEmpty(int first, int second, int third)
        {
            _intQueue.Enqueue(first);
            _intQueue.Enqueue(second);

            _intQueue.Dequeue();
            _intQueue.Dequeue();

            Assert.IsTrue(_intQueue.IsEmpty);
            Assert.IsNull(_intQueue.First);
            Assert.IsNull(_intQueue.Last);
        }

        [TestCase(1, 2, 3)]
        public void Queue_HasOne_HeadAndTailAreEqual(int first, int second, int third)
        {
            _intQueue.Enqueue(first);

            Assert.IsFalse(_intQueue.IsEmpty);
            Assert.AreEqual(_intQueue.First.Value, _intQueue.Last.Value, first);
        }

        [TestCase(1, 2, 3)]
        public void Enqueue_AddsItemToBack(int first, int second, int third)
        {
            _intQueue.Enqueue(first);
            _intQueue.Enqueue(second);
            _intQueue.Enqueue(third);

            Assert.AreEqual(_intQueue.Peek(), _intQueue.First.Value, first);
        }

        [TestCase(1, 2, 3, 4)]
        public void Dequeue_RemovesCorrectItem(int first, int second, int third, int fourth)
        {
            _intQueue.Enqueue(first);
            _intQueue.Enqueue(second);
            _intQueue.Enqueue(third);
            _intQueue.Enqueue(fourth);

            _intQueue.Dequeue();

            Assert.AreEqual(_intQueue.Peek(), second);
            Assert.AreEqual(_intQueue.Last.Value, fourth);
        }

        [TestCase(1, 2, 3)]
        public void Print_Prints(int first, int second, int third)
        {
            _intQueue.Enqueue(first);
            _intQueue.Enqueue(second);
            _intQueue.Enqueue(third);

            _intQueue.Print();
        }
    }
}
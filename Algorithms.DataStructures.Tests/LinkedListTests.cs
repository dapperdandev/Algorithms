using Algorithms.DataStructures;
using NUnit.Framework;

namespace Algorithms.DataStructures.Tests
{
    public class Tests
    {
        private LinkedList<int> _linkedList { get; set; }

        [SetUp]
        public void Setup()
        {
            _linkedList = new LinkedList<int>();
        }

        [Test]
        public void Size_IsZero()
        {
            Assert.AreEqual(_linkedList.Size(), 0);
        }

        [Test]
        public void Size_IsFive()
        {
            for(var i = 1; i <= 5; i++)
            {
                _linkedList.AddToEnd(new Node<int>(i));
            }
            Assert.AreEqual(_linkedList.Size(), 5);
        }
    }
}
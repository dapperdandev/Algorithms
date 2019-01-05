using Algorithms.DataStructures.Stack;
using NUnit.Framework;

namespace Algorithms.DataStructures.Tests
{
    [TestFixture, Parallelizable]
    public class StackTests
    {
        private Stack<int> _intStack;
        private Stack<string> _stringStack;

        [SetUp]
        public void Setup()
        {
            _intStack = new Stack<int>();
            _stringStack = new Stack<string>();
        }

        [TestCase(1, 2, 3)]
        public void Push_Int_AddsItemToTop(int first, int second, int third)
        {
            _intStack.Push(first);
            _intStack.Push(second);
            _intStack.Push(third);

            Assert.AreEqual(_intStack.Peek(), _intStack.Top.Value, third);
        }

        [TestCase("a", "b", "c")]
        public void Push_String_AddsItemToTop(string first, string second, string third)
        {
            _stringStack.Push(first);
            _stringStack.Push(second);
            _stringStack.Push(third);

            Assert.AreEqual(_stringStack.Peek(), third);
        }

        [TestCase(1, 2, 3, 4)]
        public void Pop_RemovesItem(int first, int second, int third, int fourth)
        {
            _intStack.Push(first);
            _intStack.Push(second);
            _intStack.Push(third);
            _intStack.Push(fourth);

            _intStack.Pop();

            Assert.AreEqual(_intStack.Peek(), third);
        }

        [TestCase(1, 2, 3)]
        public void Print_Prints(int first, int second, int third)
        {
            _intStack.Push(first);
            _intStack.Push(second);
            _intStack.Push(third);

            _intStack.Print();
        }
    }
}
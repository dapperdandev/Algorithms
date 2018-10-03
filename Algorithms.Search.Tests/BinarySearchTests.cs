using NUnit.Framework;

namespace Algorithms.Search.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        private readonly int[] _intArray;

        public BinarySearchTests()
        {
            _intArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(6, 5)]
        [TestCase(0, -1)]
        [TestCase(9, -1)]
        [TestCase(999, -1)]
        public void Search_SortedIntegerArray(int target, int expected)
        {
            var index = BinarySearch.Search(_intArray, target, 0, 7);

            Assert.AreEqual(index, expected);
        }
    }
}

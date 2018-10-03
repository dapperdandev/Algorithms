using NUnit.Framework;

namespace Algorithms.Search.Tests
{
    [TestFixture]
    public class LinearSearchTests
    {
        private readonly int[] _intArray;
        private readonly string[] _stringArray;

        public LinearSearchTests()
        {
            _intArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            _stringArray = new[] { "one", "two", "three", "four", "five", "six" };
        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(6, 5)]
        [TestCase(0, -1)]
        [TestCase(9, -1)]
        [TestCase(999, -1)]
        public void Search_SortedIntegerArray(int target, int expected)
        {
            var index = LinearSearch.Search(_intArray, target);

            Assert.AreEqual(index, expected);
        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(6, 5)]
        [TestCase(0, -1)]
        [TestCase(9, -1)]
        [TestCase(999, -1)]
        public void GenericSearch_SortedIntegerArray(int target, int expected)
        {
            var index = LinearSearch.GenericSearch(_intArray, target);

            Assert.AreEqual(index, expected);
        }

        [Test]
        [TestCase("one", 0)]
        [TestCase("three", 2)]
        [TestCase("six", 5)]
        [TestCase("twelve", -1)]
        [TestCase("twenty-two", -1)]
        public void GenericSearch_SortedStringArray(string target, int expected)
        {
            var index = LinearSearch.GenericSearch(_stringArray, target);

            Assert.AreEqual(index, expected);
        }
    }
}

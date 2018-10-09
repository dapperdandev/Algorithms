using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Algorithms.Sort.Tests
{

    [TestFixture]
    public class BogoSortTests
    {
        [Test]
        public void Sort_UnsortedIntegerArray()
        {
            var sortedArray = new int[] { 1, 2, 5, 5, 5, 6, 6, 8 };
            var unsortedArray = new int[] { 8, 1, 6, 5, 6, 5, 5, 2 };
            var result = BogoSort.Sort(unsortedArray);

            Assert.AreEqual(result.Item1, sortedArray);
        }

        [Test]
        public void Sort_SortedIntegerArray()
        {
            var sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = BogoSort.Sort(sortedArray);

            Assert.AreEqual(result.Item1, sortedArray);
            Assert.AreEqual(result.Item2, 0);
        }

        [Test]
        public void Sort_EqualIntegerArray()
        {
            var equalArray = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var result = BogoSort.Sort(equalArray);

            Assert.AreEqual(result.Item1, equalArray);
            Assert.AreEqual(result.Item2, 0);
        }
    }
}
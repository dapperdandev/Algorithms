using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Algorithms.Sort.Tests
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void Sort_UnsortedIntegerList()
        {
            var unsortedList = new List<int> { 8, 1, 6, 5, 6, 5, 5, 2 };
            var sortedList = new List<int>(unsortedList);
            var result = SelectionSort.Sort(unsortedList);
            
            sortedList.Sort();

            Assert.AreEqual(result, sortedList);
            Assert.AreEqual(result.Count, unsortedList.Count);

        }

        [Test]
        public void Sort_SortedIntegerList()
        {
            var sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = SelectionSort.Sort(sortedList);

            Assert.AreEqual(result, sortedList);
            Assert.AreEqual(result.Count, sortedList.Count);
        }

        [Test]
        public void Sort_EqualIntegerList()
        {
            var equalList = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var result = SelectionSort.Sort(equalList);

            Assert.AreEqual(result, equalList);
            Assert.AreEqual(result.Count, equalList.Count);
        }

        [Test]
        public void Sort_UnsortedIntegerArray()
        {
            var unsortedArray = new int[] { 8, 1, 6, 5, 6, 5, 5, 2 };
            var result = SelectionSort.Sort(unsortedArray);
            var sortedArray = new int[unsortedArray.Length];
            
            unsortedArray.CopyTo(sortedArray, 0);
            Array.Sort(sortedArray);

            Assert.AreEqual(result, sortedArray);
            Assert.AreEqual(result.Length, unsortedArray.Length);
        }
    }
}
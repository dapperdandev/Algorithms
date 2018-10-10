using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class SelectionSort
    {
        public static List<int> Sort(List<int> list)
        {
            var unsortedList = new List<int>(list); // Copy list so that referenced list is not modified (tests will fail otherwise)
            var sortedList = new List<int>();

            while (unsortedList.Count > 0)
            {
                var minIndex = 0;

                for (var i = 0; i < unsortedList.Count; i++)
                {
                    if (unsortedList[i] < unsortedList[minIndex])
                    {
                        minIndex = i;
                    }
                }

                sortedList.Add(unsortedList[minIndex]);
                unsortedList.RemoveAt(minIndex);
            }

            return sortedList;
        }
    }
}

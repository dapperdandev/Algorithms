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

        public static int[] Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var minIndex = i;

                for (var j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                var temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            return arr;
        }
    }
}

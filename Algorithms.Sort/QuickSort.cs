using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sort
{
    public class QuickSort
    {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count <= 1)
                return list;

            var lessThanPivot = new List<int>();
            var greaterThanPivot = new List<int>();
            var sortedList = new List<int>();
            var pivot = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] <= pivot)
                    lessThanPivot.Add(list[i]);
                else
                    greaterThanPivot.Add(list[i]);
            }

            sortedList.AddRange(Sort(lessThanPivot));
            sortedList.Add(pivot);
            sortedList.AddRange(Sort(greaterThanPivot));

            return sortedList;
        }
    }
}

using System.Collections.Generic;

namespace Algorithms.Search
{
    public class BinarySearch
    {
        public static int Search(int[] source, int target, int start, int end)
        {
            int mid = start + (end - start) / 2;

            if (start >= end)
                return -1;

            if (target < source[mid])
                return Search(source, target, start, mid);

            if (target > source[mid])
                return Search(source, target, mid + 1, end);

            return mid;
        }
    }
}

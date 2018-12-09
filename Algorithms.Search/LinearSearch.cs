using System.Collections.Generic;

namespace Algorithms.Search
{

    public class LinearSearch
    {
        public static int? Search(int[] source, int target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target)
                {
                    return i;
                }
            }

            return null;
        }

        public static int? GenericSearch<T>(T[] source, T target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(source[i], target))
                {
                    return i;
                }
            }

            return null;
        }
    }

}

using System;

namespace Algorithms.Sort
{
    public class BogoSort
    {
        public static Tuple<int[], int> Sort(int[] values)
        {
            var rand = new Random();
            var attempts = 0;

            while (!IsSorted(values))
            {
                attempts++;
                values.Shuffle();
            }

            return Tuple.Create(values, attempts);
        }

        private static bool IsSorted(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }

    static class ArrayExtensions
    {
        private static Random _rand = new Random();
        public static void Shuffle<T>(this T[] values)
        {
            int n = values.Length;
            while (n > 1)
            {
                // Work from the top down to avoid repeated randoms

                n--;
                int k = _rand.Next(n + 1);
                T temp = values[k];
                values[k] = values[n];
                values[n] = temp;
            }
        }
    }
}

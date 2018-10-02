using System;
using System.Collections.Generic;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            List<string> listOfStrings = new List<string> {"one", "two", "three", "four"};

            Console.WriteLine(LinearSearch(listOfNumbers, 2));
            Console.WriteLine(LinearSearch(listOfNumbers, 3));
            Console.WriteLine(LinearSearch(listOfNumbers, 0));
            Console.WriteLine(LinearSearch(listOfNumbers, 11));

            Console.WriteLine(LinearSearch(listOfStrings, "three"));
            Console.WriteLine(LinearSearch(listOfStrings, "four"));
            Console.WriteLine(LinearSearch(listOfStrings, ""));
            Console.WriteLine(LinearSearch(listOfStrings, "six"));
        }

        private static int LinearSearch<T>(List<T> list, T target)
        {
            int result = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(list[i], target))
                {
                    result = i;
                }
            }

            return result;
        }
    }
}

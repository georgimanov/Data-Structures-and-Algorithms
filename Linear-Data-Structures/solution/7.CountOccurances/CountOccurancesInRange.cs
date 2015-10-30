namespace _7.CountOccurances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /* 7.
     * Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
     * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
     * 2 → 2 times
     * 3 → 4 times
     * 4 → 3 times
     */
    class CountOccurancesInRange
    {
        static void Main(string[] args)
        {
            var list = new List<int>() {3, 4, 4, 2, 3, 3, 4, 3, 2};

            var numbers = list.GroupBy(g => g);

            foreach (var number in numbers)
            {
                Console.WriteLine("{0} → {1} times", number.Key, number.Count());
            }
        }
    }
}

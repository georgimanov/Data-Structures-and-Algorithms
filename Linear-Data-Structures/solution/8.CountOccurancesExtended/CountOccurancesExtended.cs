namespace _8.CountOccurancesExtended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /* 8*
     * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
     * Write a program to find the majorant of given array (if exists).
     * Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
     */
    class CountOccurancesExtended
    {
        static void Main()
        {
            var list = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3 };

            var size = (list.Count / 2) + 1;

            var number = list
                .GroupBy(g => g)
                .Where(s => s.Count() > size)
                .Select(x => x.Key);

            if (number.Any())
            {
                Console.WriteLine(string.Join(",", number));
            }
            else
            {
                Console.WriteLine("no result");
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Additional info:");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Size: N/2 + 1 = {0}", size);
            var occurances = list.GroupBy(o => o);
            foreach (var occurance in occurances)
            {
                Console.WriteLine("Number[{0}] -> {1} times", occurance.Key, occurance.Count());
            }
        }
    }
}

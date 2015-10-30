namespace _6.GetEvenNumbersInSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /* 6.
     * Write a program that removes from given sequence all numbers that occur odd number of times.
     * Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
     */

    static class GetEvenNumbersInSequence
    {
        static void Main()
        {
            var list = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var result = list.FindAll(x => list.Count(n => n == x) % 2 == 0);
           
            var resultAlternative = list.Where(x => list.Count(n => n == x) % 2 == 0);

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(string.Join(", ", resultAlternative));

            // what's the difference between FindAll and Where
            // http://stackoverflow.com/questions/1938204/linq-where-vs-findall
        }
    }
}

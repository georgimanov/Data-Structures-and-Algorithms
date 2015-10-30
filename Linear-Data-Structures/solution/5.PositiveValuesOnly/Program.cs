namespace _5.PositiveValuesOnly
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /* 5.
     * Write a program that removes from given sequence all negative numbers.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, -4, 5, -6, 6, -6, -6, -7, -7, -7, 8, -9, 10, -1, 1, 2, 4, 2 };

            var result = list.Where(x => x > 0).ToList();

            Console.WriteLine(string.Join(",", result));
        }
    }
}

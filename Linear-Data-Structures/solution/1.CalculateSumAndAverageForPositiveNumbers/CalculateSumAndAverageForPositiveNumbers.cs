namespace _1.CalculateSumAndAverageForPositiveNumbers
{
    /*
     * 1.
     * Write a program that reads from the console asequence of positive integer numbers. 
     * The sequence ends when empty line is entered. 
     * Calculate and print the sum and average of the elements of the sequence. 
     * Keep the sequence in List<int>.
     */
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CalculateSumAndAverageForPositiveNumbers
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var list = new List<int>();
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int number;
                if (!int.TryParse(input, out number))
                {
                    break;
                }

                if (number <= 0)
                {
                    break;
                }

                list.Add(number);
            }

            if (!list.Any())
            {
                Console.WriteLine("Empty list!");
                return;
            }

            // Using Linq
            Console.WriteLine("With Linq");
            Console.WriteLine("Sum = {0}",list.Sum());
            Console.WriteLine("Average = {0}", list.Average());
            Console.WriteLine();

            // With homemade algorithm
            int sum = CalculateSum(list);
            float average = CalculateAverage(list);

            Console.WriteLine("With homemade algorithm");
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }

        private static int CalculateSum(List<int> list)
        {
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }

            return result;
        }

        private static float CalculateAverage(List<int> list)
        {
            float result = CalculateSum(list) / list.Count;

            return result;
        }
    }
}

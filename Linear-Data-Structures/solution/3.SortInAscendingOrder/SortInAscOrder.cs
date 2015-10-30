namespace _3.SortInAscendingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /* 3.
     * Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
     */
    class SortInAscOrder
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

                list.Add(number);
            }

            if (!list.Any())
            {
                Console.WriteLine("Empty list!");
                return;
            }

            List<int> sortedList = Sort(list);

            Console.WriteLine(string.Join(",", sortedList));
        }

        private static List<int> Sort(List<int> list)
        {
            // Buble sort
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] < list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list;
        }
    }
}

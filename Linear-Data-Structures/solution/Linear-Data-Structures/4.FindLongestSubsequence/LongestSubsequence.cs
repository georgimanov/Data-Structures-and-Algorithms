namespace _4.FindLongestSubsequence
{
    using System;
    using System.Linq;

    /* 4.
     * Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
     * Write a program to test whether the method works correctly.
     */
    public class LongestSubsequence
    {
        static void Main(string[] args)
        {
            string dummyValues = "1, 2, 3, 4, 5, 6, 6, 6, 6, 7, 7, 7, 8, 9, 10, 1, 1, 2, 4, 2";

            // var readLine = Console.ReadLine();
            var readLine = dummyValues;
            if (readLine != null)
            {
                var list = readLine
                    .Trim()
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var longest = new Longest();

                var result = longest.GetLongestSubsequenceOfEqualNumbersInList(list);
                
                Console.WriteLine(string.Join(",", result));
            }
        }
    }
}

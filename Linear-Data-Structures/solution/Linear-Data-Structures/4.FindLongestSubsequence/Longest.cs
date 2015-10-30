namespace _4.FindLongestSubsequence
{
    using System.Collections.Generic;
    using System.Linq;

    public class Longest
    {
        public List<int> GetLongestSubsequenceOfEqualNumbersInList(List<int> list)
        {
            int number = list[0];
            var longestSbsequenceCounter = 1;

            for (int i = 0; i < list.Count - 1; i++)
            {
                int currentElement = list[i];
                int subsequenceCount = 1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (currentElement == list[j])
                    {
                        subsequenceCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (subsequenceCount >= longestSbsequenceCounter)
                {
                    number = currentElement;
                    longestSbsequenceCounter = subsequenceCount;
                }
            }

            return Enumerable.Repeat(number, longestSbsequenceCounter).ToList();
        }
    }
}

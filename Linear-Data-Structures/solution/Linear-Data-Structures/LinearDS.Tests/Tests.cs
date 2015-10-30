namespace LinearDS.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using _4.FindLongestSubsequence;

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ShouldReturnLongestSequenceInList()
        {
            var longestSequence = new Longest();

            var dummySeed = new List<int>() { 1, 2, 3, 4, 5, 6, 6, 6, 6, 7, 7, 7, 8, 9, 10, 1, 1, 2, 4, 2 };

            var result = longestSequence.GetLongestSubsequenceOfEqualNumbersInList(dummySeed);

            var expected = new List<int>() { 6, 6, 6, 6 };

            var resultAsString = string.Join("", result);

            var expectedAsString = string.Join("", expected);

            Assert.AreEqual(resultAsString, expectedAsString);
        }
    }
}

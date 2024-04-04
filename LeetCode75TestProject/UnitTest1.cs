namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
// Source : https://leetcode.com/problems/merge-strings-alternately/description/?envType=study-plan-v2&envId=leetcode-75
// Author : Mwazvita Mutowo
// Date   : 04/04/2024

/*************************************************************************************** 
 *
 * You are given two strings word1 and word2. 
 Merge the strings by adding letters in alternating order, starting with word1. 
 If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.
 *               
 ***************************************************************************************/

    public void MergeAlternatelyUnitTest()
    {
        Assert.AreEqual(MergeAlternately("abc", "pqr"), "apbqcr");
        Assert.AreEqual(MergeAlternately("ab", "pqrs"), "apbqrs");
        Assert.AreEqual(MergeAlternately("abcd", "pq"), "apbqcd");
    }
    public string MergeAlternately(string word1, string word2)
    {
        string mergedWord = string.Empty;

        int count = word1.Length > word2.Length ? word1.Length : word2.Length;

        for (int i = 0; i < count; i++)
        {
            if (i < word1.Length)
            {
                mergedWord += Convert.ToString(word1[i]);
            }
            if (i < word2.Length)
                mergedWord += Convert.ToString(word2[i]);
        }

        return mergedWord;
    }

}
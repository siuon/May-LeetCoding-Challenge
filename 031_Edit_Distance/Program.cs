using System;

namespace _031_Edit_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two words word1 and word2, find the minimum number of operations required to convert word1 to word2.
             * You have the following 3 operations permitted on a word:
             * Insert a character
             * Delete a character
             * Replace a character

             * Example 1:
             * Input: word1 = "horse", word2 = "ros"
             * Output: 3
             * Explanation: 
             * horse -> rorse (replace 'h' with 'r')
             * rorse -> rose (remove 'r')
             * rose -> ros (remove 'e')
             */

            var word1 = "horse";
            var word2 = "ros";

            var solution = new Solution();

            //MessageBox.Show("test");

            Console.WriteLine(solution.MinDistance(word1, word2) == 3);
        }
    }

    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            throw new NotImplementedException();
        }
    }
}

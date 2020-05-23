using System;

namespace _022_Sort_Characters_By_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sort Characters By Frequency
             * Given a string, sort it in decreasing order based on the frequency of characters.

             * Example 1:
             * Input:
             * "tree"
             * Output:
             * "eert"

             * Explanation:
             * 'e' appears twice while 'r' and 't' both appear once.
             * So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
             */

            var s = "tree";
            var solution = new Solution();

            Console.WriteLine(solution.FrequencySort(s) == "eert");
        }
    }

    public class Solution
    {
        public string FrequencySort(string s)
        {
            throw new NotImplementedException();
        }
    }
}

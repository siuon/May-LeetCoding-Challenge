using System;
using System.Collections.Generic;
using System.Linq;

namespace _017_Find_All_Anagrams_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.
             * Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.
             * The order of output does not matter.
 
             * Example 1:
             * Input:
             * s: "cbaebabacd" p: "abc"
             * Output:
             * [0, 6]

             * Explanation:
             * The substring with start index = 0 is "cba", which is an anagram of "abc".
             * The substring with start index = 6 is "bac", which is an anagram of "abc".
             */

            var s = "cbaebabacd";
            var p = "abc";

            var solution = new Solution();
            var result = solution.FindAnagrams(s, p);

            Check(result);
        }

        private static void Check(IList<int> result)
        {
            var except = new int[] { 0, 6 };

            for (int i = 0; i < except.Length; i++)
            {
                if (except[i] != result[i])
                {
                    Console.WriteLine(false);
                }
            }

            Console.WriteLine(true);
        }
    }

    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            var compareLength = p.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + p.Length > s.Length)
                {
                    break;
                }

                if (CheckAnagram(s.Substring(i, compareLength) , p))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        private bool CheckAnagram(string temp, string p)
        {
            if (String.Concat(temp.OrderBy(c => c)) ==
                String.Concat(p.OrderBy(c => c)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;

namespace _005_First_Unique_Character_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
  
             * Examples:
  
             * s = "leetcode"
             * return 0.
  
             * s = "loveleetcode",
             * return 2.

             * Note: You may assume the string contain only lowercase letters.
             */

            string s;
            var solution = new Solution();

            s = "leetcode";
            Console.WriteLine(solution.FirstUniqChar(s) == 0);

            s = "loveleetcode";
            Console.WriteLine(solution.FirstUniqChar(s) == 2);
        }
    }

    public class Solution
    {
        private int[][] _uniqList;
        private int CHAR_OFFSET = 97;

        public int FirstUniqChar(string s)
        {
            _uniqList = new int[26][];

            for (int i = 0; i < _uniqList.Length; i++)
            {
                _uniqList[i] = new int[] { 0, -1 };
            }

            int tempIndex;

            for (var i = 0; i < s.Length; i++)
            {
                tempIndex = s[i] - CHAR_OFFSET;

                if (_uniqList[tempIndex][0] == 0)
                {
                    _uniqList[tempIndex][0] += 1;
                    _uniqList[tempIndex][1] = i;
                }
                else 
                {
                    _uniqList[tempIndex][0] += 1;
                    _uniqList[tempIndex][1] = -1;
                }
            }

            var minIndex = int.MaxValue;
            var isFindUniq = false;

            foreach (var item in _uniqList)
            {
                if (item[0] == 1)
                {
                    minIndex = Math.Min(item[1], minIndex);

                    isFindUniq = true;
                }
            }

            return isFindUniq ? minIndex : -1;
        }
    }
}

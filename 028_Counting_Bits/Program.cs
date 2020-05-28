using System;
using System.Collections.Generic;

namespace _028_Counting_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non negative integer number num. 
               For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

             * Example 1:
             * Input: 2
             * Output: [0,1,1]

              Follow up:
                It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
                Space complexity should be O(n).
                Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.
             */

            var num = 2;
            var solution = new Solution();

            var expect = new int[] { 0, 1, 1};
            var result = solution.CountBits(num);

            var check = true;

            for (int i = 0; i < expect.Length; i++)
            {
                if (expect[i] != result[i])
                {
                    check = false;
                }
            }

            Console.WriteLine(check);
        }
    }

    public class Solution
    {
        private List<int> _nums;

        public int[] CountBits(int num)
        {
            _nums = new List<int>();
            int counter;
            int mask;

            for (int i = 0; i <= num; i++)
            {
                counter = 0;
                mask = (1 << 30);

                while (mask != 0)
                {
                    if ((mask & i) != 0)
                    {
                        counter++;
                    }

                    mask >>= 1;
                }

                _nums.Add(counter);
            }

            return _nums.ToArray();
        }
    }
}

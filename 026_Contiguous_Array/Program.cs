using System;

namespace _026_Contiguous_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.

             * Example 1:
             * Input: [0,1]
             * Output: 2
             * Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.
             */

            var nums = new int[] { 0, 1 };
            var solution = new Solution();

            Console.WriteLine(solution.FindMaxLength(nums) == 2);
        }
    }

    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            var maxLength = 0;
            var currentLength = 0;
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums.Length - i) < maxLength)
                {
                    break;
                }

                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                    {
                        sum--;
                    }
                    else
                    {
                        sum++;
                    }

                    currentLength++;

                    if (sum == 0)
                    {
                        maxLength = Math.Max(maxLength, currentLength);
                    }
                }

                sum = 0;
                currentLength = 0;
            }

            return maxLength;
        }
    }
}

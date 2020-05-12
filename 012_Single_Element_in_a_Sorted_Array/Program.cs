using System;

namespace _012_Single_Element_in_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are given a sorted array consisting of only integers where every element appears exactly twice, 
               except for one element which appears exactly once. Find this single element that appears only once.
  
             * Example 1: 
             * Input: [1,1,2,3,3,4,4,8,8]
             * Output: 2

             * Example 2:
             * Input: [3,3,7,7,10,11,11]
             * Output: 10
            */

            var nums = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            var solution = new Solution();

            Console.WriteLine(solution.SingleNonDuplicate(nums) == 2);
        }
    }

    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            var single = 0;

            foreach (var num in nums)
            {
                single ^= num;
            }

            return single;
        }
    }
}

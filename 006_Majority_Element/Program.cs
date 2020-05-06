using System;
using System.Linq;

namespace _006_Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
  
             * You may assume that the array is non-empty and the majority element always exist in the array.
  
             * Example 1:
             * Input: [3,2,3]
             * Output: 3

             * Example 2: 
             * Input: [2,2,1,1,1,2,2]
             * Output: 2
             */


            var solution = new Solution();

            var nums = new int[] { 3, 2, 3 };

            Console.WriteLine(solution.MajorityElement(nums) == 3);
        }
    }

    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            return nums.ToList().GroupBy(it => it)
                                .Select(group => new 
                                {
                                    num = group.Key,
                                    count = group.Count()
                                })
                                .OrderByDescending(it => it.count)
                                .First().num;
        }
    }
}

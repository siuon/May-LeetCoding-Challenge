using System;

namespace _009_Valid_Perfect_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a positive integer num, write a function which returns True if num is a perfect square else False.

             * Note: Do not use any built-in library function such as sqrt.

             * Example 1:
             * Input: 16
             * Output: true

             * Example 2:
             * Input: 14
             * Output: false
             */

            int num;
            var solution = new Solution();

            num = 2147395600;
            Console.WriteLine(solution.IsPerfectSquare(num) == true);
        }
    }

    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            var start = 1;
            var lastStart = 1;
            var end = 46340;

            for (int i = 0; i < 20; i++)
            {
                var tempNum = (start + end) / 2;
                var tempSqrt = tempNum * tempNum;

                if (tempSqrt == num)
                {
                    return true;
                }
                else if (tempSqrt > num)
                {
                    end = start + (end - start) / 2;
                }
                else
                {
                    start = tempNum;

                    if (start == lastStart)
                    {
                        start += 1;
                    }

                    lastStart = start;
                }
            }

            return false;
        }
    }
}

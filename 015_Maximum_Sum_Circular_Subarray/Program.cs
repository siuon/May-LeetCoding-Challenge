using System;

namespace _015_Maximum_Sum_Circular_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a circular array C of integers represented by A, find the maximum possible sum of a non-empty subarray of C.
             * Here, a circular array means the end of the array connects to the beginning of the array.  
               (Formally, C[i] = A[i] when 0 <= i < A.length, and C[i+A.length] = C[i] when i >= 0.)
             * Also, a subarray may only include each element of the fixed buffer A at most once.  
               (Formally, for a subarray C[i], C[i+1], ..., C[j], there does not exist i <= k1, k2 <= j with k1 % A.length = k2 % A.length.)
  
             * Example 1:
             * Input: [1,-2,3,-2]
             * Output: 3
             * Explanation: Subarray [3] has maximum sum 3

             * Note:
             * -30000 <= A[i] <= 30000
             * 1 <= A.length <= 30000
             */

            var A = new int[] { 1, -2, 3, -2 };
            var solution = new Solution();

            Console.WriteLine(solution.MaxSubarraySumCircular(A) == 3);
        }
    }

    public class Solution
    {
        public int MaxSubarraySumCircular(int[] A)
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace _023_Interval_List_Intersections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two lists of closed intervals, each list of intervals is pairwise disjoint and in sorted order.
             * Return the intersection of these two interval lists.
             * (Formally, a closed interval [a, b] (with a <= b) denotes the set of real numbers x with a <= x <= b.  
               The intersection of two closed intervals is a set of real numbers that is either empty, 
               or can be represented as a closed interval.  For example, the intersection of [1, 3] and [2, 4] is [2, 3].)

             * Example 1:
             * Input: A = [[0,2],[5,10],[13,23],[24,25]], B = [[1,5],[8,12],[15,24],[25,26]]
             * Output: [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]
             * Reminder: The inputs and the desired output are lists of Interval objects, and not arrays or lists.
             *
             * Note:
             *   0 <= A.length < 1000
             *   0 <= B.length < 1000
             *   0 <= A[i].start, A[i].end, B[i].start, B[i].end < 10^9
             
             * NOTE: input types have been changed on April 15, 2019. Please reset to default code definition to get new method signature.
             */

            var A = new int[4][];
            A[0] = new int[] { 0, 2 };
            A[1] = new int[] { 5, 10 };
            A[2] = new int[] { 13, 23 };
            A[3] = new int[] { 24, 25 };

            var B = new int[4][];
            B[0] = new int[] { 1, 5 };
            B[1] = new int[] { 8, 12 };
            B[2] = new int[] { 15, 24 };
            B[3] = new int[] { 25, 26 };
        }
    }

    public class Solution
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            throw new NotImplementedException();
        }
    }
}

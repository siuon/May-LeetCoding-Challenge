using System;

namespace _027_Possible_Bipartition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a set of N people (numbered 1, 2, ..., N), we would like to split everyone into two groups of any size.
             * Each person may dislike some other people, and they should not go into the same group. 
             * Formally, if dislikes[i] = [a, b], it means it is not allowed to put the people numbered a and b into the same group.
             * Return true if and only if it is possible to split everyone into two groups in this way.
  
             * Example 1:
             * Input: N = 4, dislikes = [[1,2],[1,3],[2,4]]
             * Output: true
             * Explanation: group1 [1,4], group2 [2,3]

               Note:
                 1 <= N <= 2000
                 0 <= dislikes.length <= 10000
                 1 <= dislikes[i][j] <= N
                 dislikes[i][0] < dislikes[i][1]
                 There does not exist i != j for which dislikes[i] == dislikes[j].
             */

            var N = 4;
            var dislikes = new int[3][];
            dislikes[0] = new int[] { 1, 2 };
            dislikes[1] = new int[] { 1, 3 };
            dislikes[2] = new int[] { 2, 4 };

            var solution = new Solution();

            Console.WriteLine(solution.PossibleBipartition(N, dislikes) == true);
        }
    }

    public class Solution
    {
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            throw new NotImplementedException();
        }
    }
}

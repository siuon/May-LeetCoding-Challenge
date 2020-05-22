using System;

namespace _021_Count_Square_Submatrices_with_All_Ones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a m * n matrix of ones and zeros, return how many square submatrices have all ones.
  
             * Example 1:
             * Input: matrix =
             * [
             *   [0,1,1,1],
             *   [1,1,1,1],
             *   [0,1,1,1]
             * ]
             * Output: 15

             * Explanation: 
             *   There are 10 squares of side 1.
             *   There are 4 squares of side 2.
             *   There is  1 square of side 3.
             *   Total number of squares = 10 + 4 + 1 = 15.
             */

            var matrix = new int[3][];
            matrix[0] = new int[] { 0, 1, 1, 1 };
            matrix[1] = new int[] { 1, 1, 1, 1 };
            matrix[2] = new int[] { 0, 1, 1, 1 };

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }

                Console.WriteLine(string.Empty);
            }
        }
    }

    public class Solution
    {
        public int CountSquares(int[][] matrix)
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace _008_Check_If_It_Is_a_Straight_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. 
               Check if these points make a straight line in the XY plane.

 　　　　　　　　　　　　　 ／
　　　　　       　　　　／
               　　　／
               　　／
               　／
               ／ 

             * Example 1:
             * Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
             * Output: true
             */

            int[][] coordinates = new int[7][];

            coordinates[0] = new int[2] { 1, 2 };
            coordinates[1] = new int[2] { 2, 3 };
            coordinates[2] = new int[2] { 3, 4 };
            coordinates[3] = new int[2] { 4, 5 };
            coordinates[4] = new int[2] { 5, 6 };
            coordinates[5] = new int[2] { 6, 7 };
            coordinates[6] = new int[2] { 7, 8 };
            // true

            coordinates[0] = new int[2] { -3, -2 };
            coordinates[1] = new int[2] { -1, -2 };
            coordinates[2] = new int[2] { 2, -2 };
            coordinates[3] = new int[2] { -2, -2 };
            coordinates[4] = new int[2] { 0, -1 };
            // true

            var solution = new Solution();

            Console.WriteLine(solution.CheckStraightLine(coordinates) == true);
        }
    }

    public class Solution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            throw new NotImplementedException();
        }
    }
}

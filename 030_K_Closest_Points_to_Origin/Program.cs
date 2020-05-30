using System;
using System.Collections.Generic;
using System.Linq;

namespace _030_K_Closest_Points_to_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We have a list of points on the plane.  Find the K closest points to the origin (0, 0).
             * (Here, the distance between two points on a plane is the Euclidean distance.)
             * You may return the answer in any order.  The answer is guaranteed to be unique (except for the order that it is in.)

             * Example 1:
             * Input: points = [[1,3],[-2,2]], K = 1
             * Output: [[-2,2]]

             * Explanation: 
             * The distance between (1, 3) and the origin is sqrt(10).
             * The distance between (-2, 2) and the origin is sqrt(8).
             * Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
             * We only want the closest K = 1 points from the origin, so the answer is just [[-2,2]].

               Note:
               1 <= K <= points.length <= 10000
               -10000 < points[i][0] < 10000
               -10000 < points[i][1] < 10000
             */

            var points = new int[2][];
            points[0] = new int[] { 1, 3 };
            points[1] = new int[] { -2, 2 };

            var K = 1;

            var solution = new Solution();

            var result = solution.KClosest(points, K);

            var expect = new int[1][];
            expect[0] = new int[] { -2, 2 };

            var valid = true;

            for (int i = 0; i < expect.Length; i++)
            {
                if (expect[i][0] != result[i][0] ||
                    expect[i][1] != result[i][1])
                {
                    valid = false;
                }
            }

            Console.WriteLine(valid);
        }
    }

    public class Solution
    {
        public int[][] KClosest(int[][] points, int K)
        {
            var datas = new List<Data>();

            foreach (var point in points)
            {
                datas.Add(new Data()
                {
                    Point = point,
                    Distance = Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2))
                });
            }

            return datas.OrderBy(it => it.Distance)
                        .Take(K)
                        .Select(it => it.Point)
                        .ToArray();
        }
    }

    public class Data
    {
        public int[] Point { get; set; }
        public double Distance { get; set; }
    }
}

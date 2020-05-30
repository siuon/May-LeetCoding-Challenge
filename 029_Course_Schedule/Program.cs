using System;

namespace _029_Course_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * There are a total of numCourses courses you have to take, labeled from 0 to numCourses-1.
             * Some courses may have prerequisites, for example to take course 0 you have to first take course 1, 
               which is expressed as a pair: [0,1]
             * Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?
  
             * Example 1:
             * Input: numCourses = 2, prerequisites = [[1,0]]
             * Output: true
             * Explanation: There are a total of 2 courses to take. 
                            To take course 1 you should have finished course 0, and to take course 0 you should
                            also have finished course 1. So it is impossible.


               Constraints:
               The input prerequisites is a graph represented by a list of edges, not adjacency matrices. Read more about how a graph is represented.
               You may assume that there are no duplicate edges in the input prerequisites.
               1 <= numCourses <= 10^5
             */

            var numCourses = 2;
            var prerequisites = new int[1][];
            prerequisites[0] = new int[] { 1, 0 };

            var solution = new Solution();

            Console.WriteLine(solution.CanFinish(numCourses, prerequisites) == true);
        }
    }

    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            throw new NotImplementedException();
        }
    }
}

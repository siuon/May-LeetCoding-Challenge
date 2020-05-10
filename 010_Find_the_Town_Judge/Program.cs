using System;
using System.Collections.Generic;
using System.Linq;

namespace _010_Find_the_Town_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In a town, there are N people labelled from 1 to N.  There is a rumor that one of these people is secretly the town judge.

             * If the town judge exists, then:
             * The town judge trusts nobody.
             *   1. Everybody (except for the town judge) trusts the town judge.
             *   2. There is exactly one person that satisfies properties 1 and 2.
             *   3. You are given trust, an array of pairs trust[i] = [a, b] representing that the person labelled a trusts the person labelled b.

             * If the town judge exists and can be identified, return the label of the town judge.  Otherwise, return -1.
 
             * Example 1:
             * Input: N = 2, trust = [[1,2]]
             * Output: 2

               Note:
   
               1 <= N <= 1000
               trust.length <= 10000
               trust[i] are all different
               trust[i][0] != trust[i][1]
               1 <= trust[i][0], trust[i][1] <= N

             */

            var trust = new int[2][];
            var n = 2;
            trust[0] = new int[] { 1, 2 };
            trust[1] = new int[] { 2, 3 };

            var solution = new Solution();

            Console.WriteLine(solution.FindJudge(n, trust) == -1);
        }
    }

    public class Solution
    {
        public int FindJudge(int N, int[][] trust)
        {
            var persons = new List<Person>();

            for (int i = 1; i <= N; i++)
            {
                persons.Add(new Person()
                {
                    N = i,
                    ByTrusted = 0,
                    TrustOther = false
                });
            }

            for (int i = 0; i < trust.Length; i++)
            {
                persons.First(it => it.N == trust[i][0]).TrustOther = true;
                persons.First(it => it.N == trust[i][1]).ByTrusted += 1;
            }

            var judge = persons.FirstOrDefault(it => it.ByTrusted == N - 1 && it.TrustOther == false);

            return judge != null ? judge.N : -1;
        }
    }

    public class Person
    {
        public int N { get; set; }
        public int ByTrusted { get; set; }
        public bool TrustOther { get; set; }
    }
}

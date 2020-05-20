using System;
using System.Collections.Generic;
using System.Linq;

namespace _020_Kth_Smallest_Element_in_a_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.
  
             * Note:
             * You may assume k is always valid, 1 ≤ k ≤ BST's total elements.

             * Example 1:
             * Input: root = [3,1,4,null,2], k = 1
             *     3
             *    / \
             *   1   4
             *    \
             *     2
             * Output: 1
             */

            var root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.left.right = new TreeNode(2);

            var k = 1;

            var solution = new Solution();

            Console.WriteLine(solution.KthSmallest(root, k) == 1);
        }
    }

    /**
     * Definition for a binary tree node.
     */
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public int KthSmallest(TreeNode root, int k)
        {
            GoTree(root);

            return _nums.OrderBy(it => it).Skip(k - 1).Take(1).First();
        }

        private List<int> _nums = new List<int>();

        private void GoTree(TreeNode node)
        {
            _nums.Add(node.val);

            if (node.left != null)
            {
                GoTree(node.left);
            }

            if (node.right != null)
            {
                GoTree(node.right);
            }
        }
    }
}

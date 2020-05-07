using System;

namespace _007_Cousins_in_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In a binary tree, the root node is at depth 0, and children of each depth k node are at depth k+1.
  
             * Two nodes of a binary tree are cousins if they have the same depth, but have different parents.
  
             * We are given the root of a binary tree with unique values, and the values x and y of two different nodes in the tree.
  
             * Return true if and only if the nodes corresponding to the values x and y are cousins.

             * Example 1:
                  1
                 / \
                2   3
               /
              4 
             * Input: root = [1,2,3,4], x = 4, y = 3
             * Output: false

             * Example 2:
                  1
                 / \
                2   3
                 \   \
                  4   5
             * Input: root = [1,2,3,null,4,null,5], x = 5, y = 4
             * Output: true

             * Example 3:
                  1
                 / \
                2   3
                 \   
                  4   
             * Input: root = [1,2,3,null,4], x = 2, y = 3
             * Output: false
  
             * Note:
             * 1. The number of nodes in the tree will be between 2 and 100.
             * 2. Each node has a unique integer value from 1 to 100.
             */

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(4);

            var solution = new Solution(); 

            Console.WriteLine(solution.IsCousins(root, 2, 3) == false);
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
        private int _depth;
        private int _parentVal;
        private int _temp;

        public bool IsCousins(TreeNode root, int x, int y)
        {
            _depth = 0;
            _parentVal = 0;

            GoTree(root, x, _depth);
            var xDepth = _depth;
            var xParent = _parentVal;

            _depth = 0;
            _parentVal = 0;

            GoTree(root, y, _depth);
            var yDepth = _depth;
            var yParent = _parentVal;

            if ((xDepth != 0 && yDepth != 0) &&
                (xParent != yParent) &&
                 xDepth == yDepth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GoTree(TreeNode node, int target, int depth)
        {
            if (node.val == target)
            {
                _depth = depth;
                _parentVal = _temp;

                return;
            }

            if (node.left != null)
            {
                _temp = node.val;
                GoTree(node.left, target, depth + 1);
            }

            if (node.right != null)
            {
                _temp = node.val;
                GoTree(node.right, target, depth + 1);
            }
        }
    }
}

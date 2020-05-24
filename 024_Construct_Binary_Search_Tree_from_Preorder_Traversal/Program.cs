using System;

namespace _024_Construct_Binary_Search_Tree_from_Preorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the root node of a binary search tree that matches the given preorder traversal.
             * (Recall that a binary search tree is a binary tree where for every node, 
               any descendant of node.left has a value < node.val, and any descendant of node.right has a value > node.val.  
               Also recall that a preorder traversal displays the value of the node first, then traverses node.left, then traverses node.right.)
             * It's guaranteed that for the given test cases there is always possible to find a binary search tree with the given requirements.
             
             * Example 1:
               Input: [8,5,1,7,10,12]
               Output: [8,5,10,1,7,null,12]

                   8
                  / \
                 5   10
                / \    \
               1   7    12

               Constraints:
                 1 <= preorder.length <= 100
                 1 <= preorder[i] <= 10^8
                 The values of preorder are distinct.

             */
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
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode rootNode = null;

            foreach (var item in preorder)
            {
                SetNode(ref rootNode, item);
            }

            return rootNode;
        }

        private void SetNode(ref TreeNode currentNode, int num)
        {
            if (currentNode == null)
            {
                currentNode = new TreeNode(num);

                return;
            }
            else if (currentNode.val < num)
            {
                SetNode(ref currentNode.right, num);
            }
            else
            {
                SetNode(ref currentNode.left, num);
            }
        }
    }
}

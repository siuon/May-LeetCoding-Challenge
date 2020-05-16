using System;

namespace _016_Odd_Even_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a singly linked list, group all odd nodes together followed by the even nodes. 
               Please note here we are talking about the node number and not the value in the nodes.
             * You should try to do it in place. The program should run in O(1) space complexity and O(nodes) time complexity.

             * Example 1:
             * Input: 1->2->3->4->5->NULL
             * Output: 1->3->5->2->4->NULL

             * Example 2:
             * Input: 2->1->3->5->6->4->7->NULL
             * Output: 2->3->6->7->1->5->4->NULL

             * Note:
             *   The relative order inside both the even and odd groups should remain as it was in the input.
             *   The first node is considered odd, the second node even and so on ...
            */

            var head = new ListNode(1, null);
            var node2 = new ListNode(2, null);
            var node3 = new ListNode(3, null);
            var node4 = new ListNode(4, null);
            var node5 = new ListNode(5, null);

            head.next = node2;
            head.next.next = node3;
            head.next.next.next = node4;
            head.next.next.next.next = node5;

            //PrintListNode(head);

            var solution = new Solution();

            PrintListNode(solution.OddEvenList(head));
        }

        private static void PrintListNode(ListNode head)
        {
            var temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
        }
    }

    /*
     * Definition for singly-linked list.
     */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null ||
                head.next == null)
            {
                return head;
            }

            ListNode oddNode = null;
            ListNode evenNode = null;
            ListNode oddNodeTemp = null;
            ListNode evenNodeTemp = null;
            var isOdd = true;
            var tempNode = head;

            while (tempNode != null)
            {
                if (isOdd)
                {
                    if (oddNode == null)
                    {
                        oddNode = tempNode;
                        oddNodeTemp = oddNode;
                    }
                    else
                    {
                        oddNodeTemp.next = tempNode;
                        oddNodeTemp = oddNodeTemp.next;
                    }
                }
                else
                {
                    if (evenNode == null)
                    {
                        evenNode = tempNode;
                        evenNodeTemp = evenNode;
                    }
                    else
                    {
                        evenNodeTemp.next = tempNode;
                        evenNodeTemp = evenNodeTemp.next;
                    }
                }

                tempNode = tempNode.next;
                isOdd = !isOdd;
            }

            oddNodeTemp.next = null;
            evenNodeTemp.next = null;

            oddNodeTemp.next = evenNode;

            return oddNode;
        }
    }
}

﻿/*

Given the head of a singly linked list, return the middle node of the linked list.
If there are two middle nodes, return the second middle node.

 Example 1:

Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
Example 2:

Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 
Constraints:

The number of nodes in the list is in the range [1, 100].
1 <= Node.val <= 100

*/

using System;

namespace middleLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static void PrintLinkedList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }

    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
            Solution s = new Solution();
            ListNode.PrintLinkedList(s.MiddleNode(head));
            ListNode.PrintLinkedList(s.MiddleNode(head2));
        }
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)
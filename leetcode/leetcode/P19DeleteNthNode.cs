using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P19DeleteNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode firstNode = null;
            ListNode secodeNode = null;

            firstNode = head;
            for (int i = 0; i < n; i++)
            {
                firstNode = firstNode.next;
            }
            if (firstNode == null)
            {
                return head.next;
            }
            secodeNode = head;

            while (firstNode.next != null)
            {
                secodeNode = secodeNode.next;
                firstNode = firstNode.next;
            }

            secodeNode.next = secodeNode.next.next;
            return head;
        }
    }


    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}

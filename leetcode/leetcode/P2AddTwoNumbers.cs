using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P2AddTwoNumbers
    {

        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {

                ListNode result = new ListNode(-1);
                ListNode curResult = result;


                ListNode currentl1 = l1;
                ListNode currentl2 = l2;

                while (currentl1 != null && currentl2 != null)
                {
                    var value = currentl1.val + currentl2.val;
                    if (value >= 10)
                    {
                        if (currentl1.next == null)
                        {
                            currentl1.next = new ListNode(1);
                        }
                        else
                        {
                            currentl1.next.val++;
                        }
                    }

                    curResult.next = new ListNode(value % 10);
                    curResult = curResult.next;

                    currentl1 = currentl1.next;
                    currentl2 = currentl2.next;
                }


                ListNode appendNode = null;
                if (currentl1 == null)
                {
                    appendNode = currentl2;
                }

                if (currentl2 == null)
                {
                    appendNode = currentl1;
                }


                curResult.next = appendNode;


                while (appendNode != null && appendNode.val > 9)
                {
                    if (appendNode.next != null)
                    {
                        appendNode.next.val++;
                    }
                    else
                    {
                        appendNode.next = new ListNode(1);
                    }
                    appendNode.val %= 10;
                    appendNode = appendNode.next;
                }

                return result.next;

            }
        }
    }
}

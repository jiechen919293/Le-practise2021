using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{



    class Leetcode203_RemoveLinkedList_Elements
    {
        //Definition for singly-linked list.
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

        //beging the process
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode temp = new ListNode();
            temp.next = head;
            var next = temp;
            while (next.next != null)
            {
                if (next.next.val = val)
                {
                    next.next = next.next.next;
                }
                else
                {
                    next = next.next;
                }
            }
            return temp.next;
        }
    }
}

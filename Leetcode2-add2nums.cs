using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode2_add2nums
    {
        /**
   * Definition for singly-linked list.   */
   public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
   
            int ca = 0;
            int n1 = 0;
            int n2 = 0;
            int n = 0;
            ListNode c1 = l1;
            ListNode c2 = l2;
            ListNode node = null;
            ListNode pre = null;
            while (c1 != null || c2 != null)
            {
                n1 = c1 != null ? c1.val : 0;
                n2 = c2 != null ? c2.val : 0;
                n = n1 + n2 + ca;
                pre = node;
                node = new ListNode(n % 10);
                node.next = pre;
                ca = n / 10;
                c1 = c1 != null ? c1.next : null;
                c2 = c2 != null ? c2.next : null;
            }
            if (ca == 1)
            {
                pre = node;
                node = new ListNode(1);
                node.next = pre;
            }
            return reverseList(node);
        }
      public ListNode reverseList(ListNode head){
        ListNode pre = null;
        ListNode next = null;
        while (head != null)
        {
            next = head.next;
            head.next = pre;
            pre = head;
            head = next;
        }
        return pre;
    }
    }
   
    
}

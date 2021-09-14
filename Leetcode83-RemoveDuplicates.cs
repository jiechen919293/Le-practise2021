using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    /**
 * Definition for singly-linked list.
 * */
     public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
          this.next = next;
      }
  }
 
    class Leetcode83_RemoveDuplicates
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode resultNode = head;
         
            while (resultNode != null&&resultNode.next!=null)
            {
                if (resultNode.val == resultNode.next.val)
                {
                    resultNode.next = resultNode.next.next;
                }
                else
                {
                    resultNode = resultNode.next;
                }

            }
            return head;
        }
    }
}

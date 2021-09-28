using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    //Definition for singly-linked list.


    class Leetcode23_mergeSortedLists
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
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null) return null;

            var resultHead = new ListNode();
            Queue<ListNode> heap = new Queue<ListNode>();

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    heap.Add(lists[i]);
                }
            }
            if (heap.IsEmpty())
            {
                return null;
            }
            ListNode head = heap.poll();
            ListNode pre = head;
            if (pre.next != null)
            {
                heap.Add(pre.next);
            }
            while (!heap.IsEmpty())
            {
                ListNode cur = heap.Poll();
                pre.next = cur;
                pre = cur;
                if (cur.next != null)
                {
                    heap.Add(cur.next);
                }
            }

            return resultHead;
        }
    }
}

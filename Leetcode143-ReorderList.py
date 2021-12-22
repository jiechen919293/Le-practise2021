# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        """
        Do not return anything, modify head in-place instead.
        """
        if not head:
            return

        # 线性表存储链表节点
        lst = []
        node = head
        while node:
            lst.append(node)
            node = node.next
        
        # 定义指针指向首尾，开始取节点重建链表
        start = 0
        end = len(lst) - 1
        while start < end:
            # 重新排列
            lst[start].next = lst[end]
            start += 1
            if start == end:
                break
            
            lst[end].next = lst[start]
            end -= 1

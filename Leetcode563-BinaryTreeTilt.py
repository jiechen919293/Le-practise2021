# Definition for a binary tree node.
from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
class Solution:
    def findTilt(self, root: Optional[TreeNode]) -> int:
        def sum_and_tilt(root):
            if not root:
                return 0, 0
            sum_left, tilt_left = sum_and_tilt(root.left)
            sum_right, tilt_right = sum_and_tilt(root.right)
            return sum_left + sum_right + root.val, abs(sum_left - sum_right) + tilt_left + tilt_right

        sum_tree, tilt_tree = sum_and_tilt(root)
        return tilt_tree


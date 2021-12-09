#Given an array of non-negative integers arr,
#  you are initially positioned at start index of the array.
#  When you are at index i, you can jump to i + arr[i] or i - arr[i], 
# check if you can reach to any index with value 0.

#Notice that you can not jump outside of the array at any time.

from typing import List


def canReach(self, arr: List[int], start: int) -> bool:

    target = 0
    for idex, num in enumerate(arr):
        if num == 0:
            target = idex
            break
    def dfs(pos, arr, meet):
        if pos < 0:return False
        if pos >= len(arr):return False
        if pos in meet:return False
        meet.add(pos)
        if arr[pos] == 0:return True
        newpos1 = pos - arr[pos]
        newpos2 = pos + arr[pos]
        return dfs(newpos1, arr, meet) or dfs(newpos2, arr, meet)
    return dfs(start, arr, set())

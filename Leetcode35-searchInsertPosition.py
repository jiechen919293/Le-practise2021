from typing import List


def searchInsert(self, nums: List[int], target: int) -> int:
    n=len(nums)
    left, right = 0,n
    while left<right:
        mid = left +(right-left)//2
        if nums[mid]==target:return mid
        elif nums[mid]>target:right=mid
        else :left =mid +1
    return left
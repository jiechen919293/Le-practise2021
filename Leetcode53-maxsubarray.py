
def maxSubArray(self, nums) -> int:
    l = len(nums)
    i = 0
    sum = 0
    MaxSum = nums[0]

    while i < l:
        sum += nums[i]
        if sum > MaxSum:
            MaxSum = sum
        if sum < 0:
            sum = 0
        i += 1
    return MaxSum

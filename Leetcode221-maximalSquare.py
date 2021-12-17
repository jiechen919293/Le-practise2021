from typing import List


class Solution:
    def maximalSquare(self, maxtrix:List[List[str]])->int:
        if not maxtrix: return 0
        M = len(maxtrix)
        N = len(maxtrix[0])
        dp = [[0] * N for _ in range(M)]
        for i in range(M):
            dp[i][0] = int(maxtrix[i][0])
        for j in range(N):
            dp[0][j] = int(maxtrix[0][j])
        for i in range(1, M):
            for j in range(1, N):
                if int(maxtrix[i][j]) == 1:
                    dp[i][j] = min(dp[i][j - 1], dp[i - 1][j], dp[i - 1][j - 1]) + 1
        return max(map(max, dp)) ** 2       
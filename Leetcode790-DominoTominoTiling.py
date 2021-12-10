
def numTilings(self,n:int)->int:
    Mod = 10**9 + 7
    if n == 1:return 1
    if n == 2:return 2
    dp = [[0 for _ in range(3)] for _ in range(n+1)]
    dp[1][0] = 1
    dp[2][0] = 2
    dp[2][1] = 1
    dp[2][2] = 1
    for i in range(3, n + 1):
        dp[i][0] = (dp[i-1][0] + dp[i-2][0] + dp[i-1][1] + dp[i-1][2]) % Mod
        dp[i][1] = (dp[i-1][2] + dp[i-2][0]) % Mod
        dp[i][2] = (dp[i-1][1] + dp[i-2][0]) % Mod
    return dp[-1][0]

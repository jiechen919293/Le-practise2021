
def nthMagicalNumber(self,n:int,a:int,b:int):
    def gcd(x, y):  # 求两个数的最小公约数
        return x if not y else gcd(y, x % y)  # 辗转取余法

    mod = 10**9 + 7
    L = a // gcd(a, b) * b  # 获取能同时被 a，b 整除的信息 L        
    def magic_below_n(n):  # 返回能整数 n包含 能被 a 或 b 整除的数个数
        return n // a + n // b - n // L  # n // a 表示能被a整除的数， n // b 表示能被b整除的数 n // L 表示能同时被a 或 b 整除的数个数
    low, high = 0, 10**15  # 初始化上下界
    while low < high:  # 进行二分查找
        mid = (low + high) // 2
        if magic_below_n(mid) < n:
           low = mid + 1
        else:
           high = mid

    return low % mod  

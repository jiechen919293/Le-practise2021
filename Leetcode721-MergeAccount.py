from typing import Collection, List

class UnionFind:

    def __init__(self, n):
        self.parent = [i for i in range(n)]

    def find(self, x):
        if x != self.parent[x]:
            self.parent[x] = self.find(self.parent[x])
        return self.parent[x]

    def union(self, x, y):
        x_root = self.find(x)
        y_root = self.find(y)
        if x_root != y_root:
            self.parent[x_root] = y_root


class Solution:
    def accountsMerge(self, accounts: List[List[str]]) -> List[List[str]]:
        n = len(accounts)
        uf = UnionFind(n)
        email_to_index = {}

        for i in range(n):
            m = len(accounts[i])
            for j in range(1, m):
                email = accounts[i][j]
                if email not in email_to_index:
                    email_to_index[email] = i

                else:
                    uf.union(i, email_to_index[email])

        index_to_email = Collection.defaultdict(list)
        for email, index in email_to_index.items():
            index_to_email[uf.find(index)].append(email)
        
        ans = []

        for index, email in index_to_email.items():
            ans.append([accounts[index][0]]+sorted(email))
        
        return ans

from typing import Collection, List


def findMinHeightTrees(self, n: int, edges: List[List[int]]) -> List[int]:
    if n == 1:
        return [0]
    leaves = Collection.defaultdict(set)
    for u, v in edges:
        leaves[u].add(v)
        leaves[v].add(u)
    que = Collection.deque()
    for u, vs in leaves.items():
        if len(vs) == 1:
            que.append(u)
    while n > 2:
        _len = len(que)
        n -= _len
        for _ in range(_len):
            u = que.popleft()
            for v in leaves[u]:
                leaves[v].remove(u)
                if len(leaves[v]) == 1:
                    que.append(v)
    return list(que)


# 版权声明：本文为CSDN博主「负雪明烛」的原创并加以修改

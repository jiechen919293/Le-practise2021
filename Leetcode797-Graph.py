class Solution:
    def allPathsSourceTarget(self, graph: List[List[int]]) -> List[List[int]]:
        res = []
        self.dfs(graph, res, 0, [0])
        return res

    def dfs(self, graph, res, pos, path):
        if pos == len(graph) - 1:
            res.append(path)
            return
        else:
            for n in graph[pos]:
                self.dfs(graph, res, n, path + [n])

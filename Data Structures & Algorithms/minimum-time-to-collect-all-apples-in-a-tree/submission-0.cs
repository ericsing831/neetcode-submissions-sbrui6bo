public class Solution {
    public int MinTime(int n, int[][] edges, List<bool> hasApple) {
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        foreach (var edge in edges) {
            int child = edge[0];
            int parent = edge[1];
            graph[child].Add(parent);
            graph[parent].Add(child);
        }
        int dfs(int cur, int parent) {
            int time = 0;
            foreach (int child in graph[cur]) {
                if (child == parent) continue;
                int childTime = dfs(child, cur);
                if ((childTime > 0) || (hasApple[child])) {
                    time += 2 + childTime;
                }
            }
            return time;
        }
        return dfs(0, -1);
    }
}
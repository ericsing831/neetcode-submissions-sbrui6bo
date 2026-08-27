public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        var stack = new Stack<(int temp, int index)>();
        for (int i = 0; i < temperatures.Length; i++) {
            while (stack.Count != 0 && temperatures[i] > stack.Peek().temp) {
                var dummy = stack.Pop();
                res[dummy.index] = i - dummy.index;
            }
            stack.Push((temperatures[i], i));
        }
        return res;
    }
}

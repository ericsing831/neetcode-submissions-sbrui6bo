public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<(int temp, int index)>();
        var res = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length; i++) {
            while (stack.Count != 0 && temperatures[i] > stack.Peek().temp) {
                var dummy = stack.Pop();
                res[dummy.index] = i - dummy.index;
            }
            stack.Push((temperatures[i] ,i));
        }
        return res;
    }
}

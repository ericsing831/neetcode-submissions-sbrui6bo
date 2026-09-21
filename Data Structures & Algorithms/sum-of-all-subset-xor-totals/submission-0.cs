public class Solution {
    public int SubsetXORSum(int[] nums) {
        // XORSum(3C0 + 3C1 + 3C2 + 3C3)
        var res = new List<Stack<int>>();
        
        for (int i = 0; i <= nums.Length; i++) {
            var stack = new Stack<int>();
            NXORList(nums, i, stack);
        }
        
        int xorSum = 0;
        foreach (var subStack in res) {
            int xorSubSum = 0;
            foreach (var element in subStack) {
                xorSubSum = xorSubSum ^ element;
            }
            xorSum += xorSubSum;
        }
        return xorSum;

        void NXORList(int[] nums, int n, Stack<int> stack) {
            if (stack.Count == n) {
                Stack<int> copy = new Stack<int>(stack.Reverse());
                res.Add(copy);
                return;
            }
            for (int i = 0; i < nums.Length; i++) {
                stack.Push(nums[i]);
                NXORList(nums[(i + 1)..], n, stack);
                stack.Pop();
            }
        }
    }
}
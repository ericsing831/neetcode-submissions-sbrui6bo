public class Solution {
    private int res = 0;

    public int SubsetXORSum(int[] nums) {
        BackTrack(nums, new Stack<int>());
        return res;
        
        void BackTrack(int[] nums, Stack<int> subset) {
            int xorSum = 0;
            foreach (int num in subset) {
                xorSum ^= num;
            }
            res += xorSum;

            for (int j = 0; j < nums.Length; j++) {
                subset.Push(nums[j]);
                BackTrack(nums[(j + 1)..], subset);
                subset.Pop();
            }
        }
    }
}
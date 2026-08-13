public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int cnt = 0;
        int curSum = 0;
        // [2, 1, 2, 4]
        // [2, -1, 1, 2]
        var prefixSum = new Dictionary<int, int>();
        prefixSum[0] = 1;
        for (int i = 0; i < nums.Length; i++) {
            curSum += nums[i];
            int diff = curSum - k;

            cnt += prefixSum.GetValueOrDefault(diff, 0);
            prefixSum[curSum] = 1 + prefixSum.GetValueOrDefault(curSum, 0);
        }
        return cnt;
    }
}
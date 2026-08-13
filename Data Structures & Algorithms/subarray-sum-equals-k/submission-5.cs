
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
            if (prefixSum.TryGetValue(diff, out int value)) {
                cnt += value;
            }
            if (prefixSum.TryGetValue(curSum, out int val)) {
                prefixSum[curSum] = val + 1;
            }
            else 
                prefixSum[curSum] = 1;
        }
        return cnt;
    }
}

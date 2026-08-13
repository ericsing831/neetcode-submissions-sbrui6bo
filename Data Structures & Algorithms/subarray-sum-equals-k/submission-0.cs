public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int[] prefixSum = new int[nums.Length];
        int sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i]; 
            prefixSum[i] = sum;
        }
        // [2, 1, 2, 4]
        // [4, 8, 12, 16, 20, 24]
        int cnt = 0;
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i; j < nums.Length; j++) {
                if (prefixSum[j] == k) 
                    cnt++;
                prefixSum[j] -= nums[i];
            }
        }
        return cnt;
    }
}
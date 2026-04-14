public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        if (nums.Sum() < target) return 0;
        int left = 0;
        int sumRangeLen = int.MaxValue; 
        int count = 0;
        
        for (int right = 0; right < nums.Length; right++) {
            count += nums[right];
            while (count >= target) {
                sumRangeLen = Math.Min(sumRangeLen, right - left + 1);
                count -= nums[left];
                left++;
            }
        }
        return sumRangeLen;
    }
}
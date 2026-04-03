public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];
        for (int i = 0, j = 0; i < ans.Length; i++) {
            ans[i] = nums[j];
            j++;
            if (j == nums.Length) j = 0; 
        }
        return ans;
    }
}
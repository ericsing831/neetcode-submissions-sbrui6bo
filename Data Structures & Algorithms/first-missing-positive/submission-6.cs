public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) {
                nums[i] = 0;
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            int idx = Math.Abs(nums[i]);
            if (idx < 1 || idx > nums.Length) continue;
            // do not alter val if val is negative
            if (nums[idx - 1] > 0) {
                nums[idx - 1] *= -1;
            }
            else if (nums[idx - 1] == 0) {
                nums[idx - 1] = -(nums.Length + 1);
            }
        }
        for (int i = 1; i < nums.Length + 1; i++) {
            if (nums[i - 1] >= 0) {
                return i;
            }
        }
        return nums.Length + 1;
    }
}
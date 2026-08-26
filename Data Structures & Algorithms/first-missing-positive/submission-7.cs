public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) {
                nums[i] = 0;
            }
        }

// only make sure the integer appeared in array 
// so make a record by marking the element which index equal the value as -1
// the max positive in this array will be length of nums - 1
        for (int i = 0; i < nums.Length; i++) {
            int idx = Math.Abs(nums[i]);
            if (0 < idx && idx < nums.Length + 1) {
                if (nums[idx - 1] > 0)
                    nums[idx - 1] *= -1;
                else if (nums[idx - 1] == 0)
                    nums[idx - 1] = -(nums.Length + 1);
            }
        }

        for (int i = 1; i < nums.Length + 1; i++) {
            if (nums[i - 1] >= 0)
                return i;
        }
        return nums.Length + 1;
    }
}
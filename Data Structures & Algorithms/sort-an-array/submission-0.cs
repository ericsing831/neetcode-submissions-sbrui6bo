public class Solution {
    public int[] SortArray(int[] nums) {
        for (int i = 1; i < nums.Length; i++) {
            int j = i - 1;
            while (j >= 0 && nums[j+1] < nums[j]) {
                int tmp = nums[j];
                nums[j] = nums[j+1];
                nums[j+1] = tmp;
                j--;
            }
        }
        return nums;
    }
}
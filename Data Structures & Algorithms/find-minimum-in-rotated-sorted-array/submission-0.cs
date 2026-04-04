public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        int res = nums[0];
        while (l <= r) {
            if (nums[r] > nums[l]) { // the input array is sorted
                res = Math.Min(nums[l], res);
                break;
            }
            int m = (l + r) / 2;
            res = Math.Min(nums[m], res);
            if (nums[m] >= nums[l]) {
                l = m + 1;
            }
            else {
                r = m - 1;
            }
        }
        return res;
    }
}

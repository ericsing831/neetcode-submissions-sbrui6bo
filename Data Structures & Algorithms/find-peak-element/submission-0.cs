public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        while (l < r) {
            int m = (l + r) / 2;
            // if mid + 1 > mid, a slope upwards appears from mid, whcih means peak must be shown in nums[mid + 1..]
            // else mid > mid + 1,
            if (nums[m + 1] > nums[m]) {
                l = m + 1;
            }
            else {
                r = m;
            }
        }
        return l;
    }
}
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        int index = 0;
        while (l <= r) {
            int mid = (l + r) / 2;
            if (nums[mid] > target) {
                index = mid;
                r = mid - 1;
            }
            else if (nums[mid] < target) {
                index = mid + 1;
                l = mid + 1;
            }
            else {
                index = mid;
                return mid;
            }
        }
        return index;
    }
}
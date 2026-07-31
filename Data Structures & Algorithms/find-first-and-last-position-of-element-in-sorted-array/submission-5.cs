public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int BinarySearch(int target) {
            int left = 0;
            int right = nums.Length;
            while (left < right) {
                int mid = (left + right) / 2;
                if (nums[mid] >= target) {
                    right = mid;
                }
                else left = mid + 1;
            }
            return left;
        }
        int start = BinarySearch(target);
        int end = BinarySearch(target + 1);
        if (start == nums.Length || nums[start] != target)
            return new int[] {-1, -1};
        return new int[] {start, end - 1};
    }
}
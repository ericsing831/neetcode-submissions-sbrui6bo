public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        if (nums.Length == 0) return new int[] {-1, -1};

        while (left < right) {
            int mid = (left + right) / 2; 
            if (nums[mid] >= target) 
                right = mid;
            else 
                left = mid + 1;
        }
        int resL = left;

        right = nums.Length - 1;
        while (left < right) {
            int mid = left + (right - left + 1) / 2;
            if (nums[mid] > target)
                right = mid - 1;
            else 
                left = mid;
        }
        if (nums[resL] == target)
            return new int[2] {resL, right};
        else return new int[2] {-1, -1};
    }
}
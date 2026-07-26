public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int right = nums.Length - 1, left = 0;
        int mid;
        while (right > left) {
            mid = left + (right - left) / 2;
            if (mid % 2 == 1) mid--;
            // if the num[mid] and num[mid + 1] is the same element, the unique element is in nums[mid+2..]
            if (isSameElement(mid)) {
                left = mid + 2;
            }
            else right = mid;
        }
        return nums[left];

        bool isSameElement(int mid) {
            return nums[mid] == nums[mid + 1];
        }
    }
}
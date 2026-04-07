public class Solution {
    public bool Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            
            if (nums[mid] == target) return true;
            if (nums[left] == nums[mid] && nums[mid] == nums[right]) {
                right--;
                left++;
                continue;
            }


            // case arr[l - m] is sorted
            if (nums[mid] >= nums[left]) {
                // target not in left arr
                if (target < nums[left] || nums[mid] < target) {
                    left = mid + 1;
                }
                // target search range in arr 
                else {
                    // abondon right segment
                    // search for target
                    if (target == nums[mid] || target == nums[left]) return true;
                    right = mid - 1;
                }
            }
            // case arr[m + 1 - r] is sorted
            else {
                // target not in right arr
                if (target < nums[mid] || nums[right] < target) {
                    right = mid - 1;
                }
                else {
                    if (target == nums[mid] || target == nums[left]) return true;
                    left = mid + 1;
                }
            }
        }
        return false;
    }
}
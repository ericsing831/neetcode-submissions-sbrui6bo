public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            int mid = (left + right) / 2;

            if (nums[mid] == target) return mid;
        
            //left segment is sorted
            if (nums[mid] >= nums[left]) { 
                //target outside of left segment
                if (target < nums[left] || target > nums[mid]) { 
                    //left segment abandoned
                    left = mid + 1; 
                }
                //target inside of left segment
                else {
                    //right segment abandoned
                    right = mid - 1;
                }
            }
            //right segment is sorted
            else { 
                //target outside of right segment 
                if (target < nums[mid] || target > nums[right]) { 
                    //right segment abandoned
                    right = mid - 1; 
                }
                //target inside of right segment
                else {
                    // left segment abandoned
                    left = mid + 1;
                }
            } 
        }
        return -1;
    }
}

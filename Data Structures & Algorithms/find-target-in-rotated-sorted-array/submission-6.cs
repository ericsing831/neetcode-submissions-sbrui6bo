public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while (l <= r) {
            int m = (l + r) / 2;
            if (nums[m] == target) return m;
            if (nums[l] <= nums[m]) { // a sorted segment
                if (nums[l] <= target && target < nums[m]) { //target in sorted segment
                    r = m - 1;
                    m = (l + r) / 2;
                    if (nums[m] > target) {
                        r = m - 1;
                    }
                    else if (nums[m] < target) {
                        l = m + 1;
                    }
                    else {
                        return m;
                    }
                }
                else 
                    l = m + 1;
            }
            else { // a ratated segment 
                if (nums[m] < target && target <= nums[r]) 
                    l = m + 1;
                else 
                    r = m - 1;
            }
        }
        return -1;
    } 
}

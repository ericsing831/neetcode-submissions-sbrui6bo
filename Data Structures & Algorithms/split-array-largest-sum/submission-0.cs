public class Solution {
    public int SplitArray(int[] nums, int k) {
        int left = nums.Max();
        int right = nums.Sum();
        int res = nums.Sum();
        
        while (left <= right) {
            int mid = (left + right) / 2;
            if (isValid(mid)) {
                right = mid - 1;
                res = mid;
            }
            else
                left = mid + 1;
        }
        return res;

        bool isValid(int target) {
            int cnt = 1;
            int i = 0;
            int sum = 0;
            while (i < nums.Length) {
                sum += nums[i];
                if (sum > target) {
                    sum = nums[i];
                    cnt++;
                }
                if (cnt > k) {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
public class Solution {
    public int MinimizeMax(int[] nums, int p) {

        bool isValid(int thereshold) {
            int i = 0;
            int count = 0;
            while (i < nums.Length - 1) {
                if (Math.Abs(nums[i] - nums[i + 1]) <= thereshold) {
                    count++;
                    i += 2;
                }
                else 
                    i++;
                
                if (count == p) 
                    return true;
            }
            return false;
        }

        if (p == 0) return 0;

        Array.Sort(nums);
        int left = 0;
        int right = 1000000000;
        int res = 1000000000;

        while (left <= right) {
            int mid = (left + right) / 2;
            if (isValid(mid)) {
                res = mid;
                right = mid - 1;
            }
            else 
                left = mid + 1;
        }
        return res;
    }
}
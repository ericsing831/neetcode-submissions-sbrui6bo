public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();
        int l = 0, r = 0;
        while (r < nums.Length) {
            if (r - l > k) {
                set.Remove(nums[l]);
                l++;
            }
            if (!set.Add(nums[r])) {
                return true;
            }
            r++;
        }
        return false;
    }
}
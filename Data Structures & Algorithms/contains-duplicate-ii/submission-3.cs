public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();
        int j = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (i - j > k) {
                set.Remove(nums[j]);
                j++;
            }
            if (set.Contains(nums[i])) {
                return true;
            }
            set.Add(nums[i]);
        }
        return false;
    }
}
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            // has duplicate
            if (dict.ContainsKey(nums[i])) {
                if (Math.Abs(dict[nums[i]] - i) <= k) {
                    return true;
                }
                dict[nums[i]] = i;
            }
            else {
                dict.Add(nums[i], i);
            }
        }
        return false;
    }
}
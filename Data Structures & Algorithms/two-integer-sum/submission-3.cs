public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = null;
        var dict = new Dictionary<int, (int integer, int index)>();
        for (int i = 0; i < nums.Length; i++) {
            dict[(target - nums[i])] = (nums[i], i);
        }
        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i])) {
                if (i != dict[nums[i]].index)
                    res = new int[] {i, dict[nums[i]].index};
            }
        }
        Array.Sort(res);
        return res;
    }
}

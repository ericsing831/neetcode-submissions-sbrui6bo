public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        int i;
        for (i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (!dict.ContainsKey(diff)) 
                dict[nums[i]] = i;
            else {
                return new int[] {dict[diff], i};
            }
        }
        return null;
    }
}

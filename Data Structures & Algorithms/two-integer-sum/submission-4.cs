public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        int i;
        int j = 0;
        for (i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (!dict.ContainsKey(diff)) 
                dict[nums[i]] = i;
            else {
                j = dict[diff];
                break;
            }
        }
        return new int[] {j, i};
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> intDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            intDict[nums[i]] = target - nums[i];
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] + intDict[nums[i]] == target) {
                int j;
                for (j = 0; j < nums.Length; j++) {
                    if (i == j) continue;
                    if (nums[j] == intDict[nums[i]]) {
                        return new int[] {i, j};
                    }
                }
            }
        }       
        return new int[] {-1, -1}; 
    }
}

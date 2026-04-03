public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        var set = new HashSet<int>(nums);
        
        int longest = 0;
        foreach (int num in nums) {
            if (!set.Contains(num-1)) {
                int length = 0;
                while (set.Contains(num + length)) {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}

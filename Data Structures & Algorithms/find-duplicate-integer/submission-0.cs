public class Solution {
    public int FindDuplicate(int[] nums) {
        // phase 1: find point where fast and slow meet
        int fast = 0;
        int slow = 0;
        slow = nums[slow];
        fast = nums[nums[fast]];
        while (slow != fast) {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        // phase 2: find point where slow and slow2 meet
        int slow2 = 0;
        slow2 = nums[slow2];
        slow = nums[slow];
        while (slow != slow2) {
            slow = nums[slow];
            slow2 = nums[slow2];
        }
        return slow2;
    }
}

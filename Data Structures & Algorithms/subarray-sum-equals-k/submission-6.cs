public class Solution {
    public int SubarraySum(int[] nums, int k) {
        //[2, -1, 1, 2]
        //[2, 1, 2, 4]
        var dict = new Dictionary<int, int>();
        int cnt = 0;
        int curSum = 0;
        dict[0] = 1;
        foreach (int num in nums) {
            curSum += num;
            int diff = curSum - k;
            cnt += dict.GetValueOrDefault(diff, 0);
            dict[curSum] = dict.GetValueOrDefault(curSum, 0) + 1;
        }
        return cnt;
    }
}
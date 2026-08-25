public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var map = new Dictionary<long, int>();
        foreach (int num in nums) {
            map[num] = map.GetValueOrDefault(num, 0);
        }

        for (int i = 1; i <= int.MaxValue; i++){
            if (!map.TryGetValue(i, out int val)) {
                return i;
            }
        }
        
        return 1;
    }
}       
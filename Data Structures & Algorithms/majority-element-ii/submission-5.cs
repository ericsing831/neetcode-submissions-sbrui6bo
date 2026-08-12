public class Solution {
    public List<int> MajorityElement(int[] nums) {
        return nums
                .GroupBy(x => x)
                .Where(x => x.Count() > nums.Length / 3)
                .Select(x => x.Key)
                .ToList();
    }
}
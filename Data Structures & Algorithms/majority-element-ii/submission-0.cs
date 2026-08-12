public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int threhold = nums.Length / 3;
        var res = new Dictionary<int, int>();
        foreach (int i in nums) {
            res[i] = res.GetValueOrDefault(i) + 1;
        }
        foreach (int i in res.Keys) {
            if (res[i] <= threhold) 
                res.Remove(i);
        }
        return res.Keys.ToList();
    }
}
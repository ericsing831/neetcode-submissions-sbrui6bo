public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int cand1 = int.MinValue;
        int cand2 = int.MinValue;
        int cnt1 = 0;
        int cnt2 = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == cand1) 
                cnt1++;
            else if (nums[i] == cand2) 
                cnt2++;
            else if (cnt1 == 0) {
                cand1 = nums[i];
                cnt1 = 1;
            }
            else if (cnt2 == 0) {
                cand2 = nums[i];
                cnt2 = 1;
            }
            else {
                cnt1--;
                cnt2--;
            }
        }

        cnt1 = 0;
        cnt2 = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (cand1 == nums[i])
                cnt1++;
            else if (cand2 == nums[i]) 
                cnt2++;
        }

        int threshold = (nums.Length / 3);
        var res = new List<int>();
        if (cnt1 > threshold) 
            res.Add(cand1);
        if (cnt2 > threshold)
            res.Add(cand2);
        
        return res;
        
    }
}
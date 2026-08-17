public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int cand1 = int.MinValue;
        int cand2 = int.MinValue;
        int cnt1 = 0;
        int cnt2 = 0;

        foreach (int num in nums) {
            if (cand1 == num) 
                cnt1++;
            else if (cand2 == num)
                cnt2++;
            else if (cnt1 < 1) {
                cand1 = num;
                cnt1 = 1;
            }
            else if (cnt2 < 1) {
                cand2 = num;
                cnt2 = 1;
            }
            else {
                cnt1--;
                cnt2--;
            }
        }

        cnt1 = 0;
        cnt2 = 0;
        foreach (int num in nums) {
            if (cand1 == num)
                cnt1++;
            else if (cand2 == num)
                cnt2++;
        }
        int threshold = nums.Length / 3;
        var list = new List<int>();
        if (cnt1 > threshold) {
            list.Add(cand1);
        }
        if (cnt2 > threshold) {
            list.Add(cand2);
        }
        return list;
    }
}
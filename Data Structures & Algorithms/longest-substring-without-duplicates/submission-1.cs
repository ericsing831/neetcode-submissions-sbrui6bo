public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        var window = new HashSet<char>();
        int res = 0;

        for (int r = 0; r < s.Length; r++){
            window.Add(s[r]);
            while ((r - l + 1) > window.Count) {
                window.Remove(s[l]);
                l++;
                window.Add(s[r]);
            }
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}

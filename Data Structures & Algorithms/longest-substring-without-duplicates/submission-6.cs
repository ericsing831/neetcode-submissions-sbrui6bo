public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var window = new Dictionary<char, int>();
        int res = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++){
            if (window.ContainsKey(s[r])) {
                l = Math.Max(l, window[s[r]] + 1);
            }
            window[s[r]] = r;
            res = Math.Max(res, r - l + 1);
        }
        
        return res;
    }
}
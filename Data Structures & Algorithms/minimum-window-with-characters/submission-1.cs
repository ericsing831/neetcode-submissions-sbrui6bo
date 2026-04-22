public class Solution {
    public string MinWindow(string s, string t) {
        if (t == "") return "";
        if (t.Length > s.Length) return "";

        var window = new Dictionary<char, int>();
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++) {
            if (dict.ContainsKey(t[i])) {
                dict[t[i]] += 1;
            }
            else {
                dict[t[i]] = 1;
            }
        }

        int have = 0, need = dict.Count;
        (int left, int right) res = (-1, -1);
        int resLen = int.MaxValue;

        int l = 0;        
        for (int r = 0; r < s.Length; r++) {
            char c = s[r];
            if (window.ContainsKey(c)) {
                window[c] += 1;
            }
            else {
                window[c] = 1;
            }

            if (dict.ContainsKey(c) && window[c] == dict[c]) {
                have++;
            }
            
            while (have == need) {
                // update result
                if ((r - l + 1) < resLen) {
                    res = (l, r);
                    resLen = r - l + 1;
                }
                // pop from left of window
                window[s[l]]--;
                if (dict.ContainsKey(s[l]) && window[s[l]] < dict[s[l]]) {
                    have--;
                }
                l++;
            }
        }
        return resLen == int.MaxValue ? "" : s[res.left..(res.right+1)];
    }
}

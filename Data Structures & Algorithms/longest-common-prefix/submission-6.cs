public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string lcp = strs[0];
        foreach (string str in strs) {
            if (str == "") return "";
            int i = 0;
            int len = Math.Min(lcp.Length, str.Length);
            lcp = lcp[0..len];
            for (; i < len; i++) {
                if (lcp[i] != str[i]) {
                    lcp = lcp[0..i];
                    break;
                }
            }
        }
        return lcp;
    }
}
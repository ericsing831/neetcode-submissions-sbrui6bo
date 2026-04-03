public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string lcp = strs[0];
        foreach (string str in strs) {
            if (str == "") return "";  
            int len = Math.Min(lcp.Length, str.Length);
            lcp = lcp[0..len];
            for (int i = 0; i < len; i++) {
                if (lcp[i] != str[i]) {
                    lcp = lcp[0..i];
                    break;
                }
            }
        }
        return lcp;
    }
}
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var alphabets = new int[26];
        int offset = (int)'a';
        for (int i = 0; i < s.Length; i++) {
            alphabets[(int)s[i] - offset]++;
            alphabets[(int)t[i] - offset]--;
        }
        for (int i = 0; i < 26; i++) {
            if (alphabets[i] > 0) return false;
        }
        return true;
    }
}

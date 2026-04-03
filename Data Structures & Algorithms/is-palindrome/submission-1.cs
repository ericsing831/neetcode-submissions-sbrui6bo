public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0, j = s.Length - 1;
        while (i < j) {
            if (!Char.IsAsciiLetterOrDigit(s[i])) {
                i++;
                continue;
            }
            if (!Char.IsAsciiLetterOrDigit(s[j])) {
                j--;
                continue;
            }
            if (Char.ToUpper(s[i]) != Char.ToUpper(s[j])) {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}

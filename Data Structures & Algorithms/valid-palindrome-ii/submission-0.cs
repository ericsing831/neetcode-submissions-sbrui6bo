public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0, right = s.Length - 1;

        while (left < right) {
            if (s[left] != s[right]) {
                string skipL = s[(left + 1)..(right + 1)];
                string skipR = s[left..right];
                return IsPalindrome(skipL) || 
                        IsPalindrome(skipR);
            }
            left++;
            right--;
        }
        return true;
    }

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
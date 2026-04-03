public class Solution {
    public void ReverseString(char[] s) {
        int left = 0, right = s.Length - 1;
        while (left < right) {
            char tempChar = s[left];
            s[left] = s[right];
            s[right] = tempChar;
            left++;
            right--;
        }
    }
}
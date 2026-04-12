public class Solution {
    public int CharacterReplacement(string s, int k) {

        int l = 0;
        int length = 0;
        int maxFreq = 0;
        int[] count = new int[26];
        for (int r = 0; r < s.Length; r++) {
            count[s[r] - 'A']++;
            maxFreq = Math.Max(maxFreq, count[s[r] - 'A']);
            while ((r - l + 1) - maxFreq > k) {
                count[s[l] - 'A']--;
                l++;
            }
            length = Math.Max(length, r - l + 1);
        }
        return length;
    }
}

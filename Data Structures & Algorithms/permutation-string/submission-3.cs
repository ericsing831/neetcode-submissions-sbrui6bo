public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        var arr = new int[26];
        var compareArr = new int[26];

        for (int r = 0; r < s1.Length; r++) {
            arr[s1[r] - 'a']++;
            compareArr[s2[r] - 'a']++;
        }

        if (arr.SequenceEqual(compareArr)) {
            return true;
        }
        int len = s1.Length;
        for (int l = 1; l < s2.Length - s1.Length + 1; l++) { 
            compareArr[s2[l - 1] - 'a']--;
            compareArr[s2[l + len - 1] - 'a']++;

            if (arr.SequenceEqual(compareArr)) {
                return true;
            }
        }
        return false; 
    }
}

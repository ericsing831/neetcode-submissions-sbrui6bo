public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false; 

        int[] count1 = new int[26];
        int[] count2 = new int[26];
        for (int i = 0; i < s1.Length; i++) {
            count1[s1[i] - 'a']++;
            count2[s2[i] - 'a']++;
        }

        int matches = 0;
        for (int i = 0; i < count1.Length; i++) {
            if (count1[i] == count2[i]) {
                matches++;
            }
        }

        if (matches == 26) return true; 

        int l = 0; 
        for (int r = s1.Length; r < s2.Length; r++) {
            // window right side operation
            int index = s2[r] - 'a';
            count2[index]++;
            if (count1[index] == count2[index]) {
                matches++;
            }
            else if (count1[index] + 1 == count2[index]) {
                matches--;
            }
            // window left side operation
            index = s2[l] - 'a';
            count2[index]--;
            if (count1[index] == count2[index]) {
                matches++;
            }
            else if (count1[index] - 1 == count2[index]) {
                matches--;
            }
            l++;
            if (matches == 26) return true; 
        }
        return false; 
    }
}

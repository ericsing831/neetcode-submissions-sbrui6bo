public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        var arr = new int[26];
        for (int r = 0; r < s1.Length; r++) {
            arr[s1[r] - 'a']++;
        }

        for (int l = 0; l < s2.Length - s1.Length + 1; l++) {
            var testArr = arr.ToArray(); 
            for (int r = l; r < l + s1.Length; r++) {
                testArr[s2[r] - 'a']--;
            }
            if (testArr.All(x => x == 0)) {
                return true;
            }
        }
        return false; 
    }
}

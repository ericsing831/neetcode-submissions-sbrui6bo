public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int w1 = 0;
        int w2 = 0;
        string res = "";
        while (w1 < word1.Length || w2 < word2.Length) {
            if (w1 < word1.Length) {
                res += word1[w1];
                w1++;
            }
            if (w2 < word2.Length) {
                res += word2[w2];
                w2++;
            }
        }
        return res;
    }
}
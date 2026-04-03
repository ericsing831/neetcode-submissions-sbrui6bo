public class Solution {
    public string MergeAlternately(string word1, string word2) {
        if(string.IsNullOrEmpty(word1))
        {
            return word2;
        }

        if(string.IsNullOrEmpty(word2))
        {
            return word1;
        }

        int w1 = 0;
        int w2 = 0;
        var res = new StringBuilder();
        while (w1 < word1.Length || w2 < word2.Length) {
            if (w1 < word1.Length) {
                res.Append(word1[w1]);
                w1++;
            }
            if (w2 < word2.Length) {
                res.Append(word2[w2]);
                w2++;
            }
        }
        return res.ToString();
    }
}
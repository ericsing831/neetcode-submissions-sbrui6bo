public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new List<List<string>>();
        int i = 1;
        res.Add(new List<string>(){strs[0]});

        while (i < strs.Length) {
            bool added = false;
            foreach (List<string> subRes in res) {
                if (isAnagrams(subRes[0], strs[i])) {
                    subRes.Add(strs[i]);
                    added = true;
                }
            }
            if (!added)
                res.Add(new List<string>(){strs[i]});
            i++;
        }

        return res;

        bool isAnagrams(string a, string b) {
            if (a.Length != b.Length) return false;
            int offset = (int)'a';
            int[] alphabets = new int[26];
            for (int i = 0; i < a.Length; i++) {
                alphabets[(int)a[i] - offset]++;
                alphabets[(int)b[i] - offset]--;
            }
            foreach (int i in alphabets) {
                if (i != 0) 
                    return false;
            }
            return true;
        }
    }
}

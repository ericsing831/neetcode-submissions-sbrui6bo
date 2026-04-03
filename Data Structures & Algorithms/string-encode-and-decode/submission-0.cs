public class Solution {

    public string Encode(IList<string> strs) {
        for (int i = 0; i < strs.Count; i++) {
            int len = strs[i].Length;
            strs[i] = len.ToString() + "#" + strs[i];
        }
        return string.Join("",strs);
    }

    public List<string> Decode(string s) {
        int curr = 0;
        List<string> strs = new List<string>();
        while (curr < s.Length) {
            int j = curr;
//locate length index
            while (s[j] != '#') {
                j++;
            }
            int len = int.Parse(s[curr..j].ToString());
            int end = j + len + 1;
            int start = j + 1;
            strs.Add(s[start..end]);
            curr = end;
        }
        return strs;
   }
}

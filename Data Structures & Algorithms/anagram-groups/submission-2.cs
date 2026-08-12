public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach (string str in strs) {
            var arr = new int[26];
            for (int i = 0; i < str.Length; i++) {
                arr[str[i] - 'a']++;
            }
            var key = string.Join(",", arr);
            if (res.TryGetValue(key, out List<string> values))
                values.Add(str);
            else {
                values = new List<string>{str};
                res.Add(key, values);
            }
        }
        return res.Values.ToList();
    }
}

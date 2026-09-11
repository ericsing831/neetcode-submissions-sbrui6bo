public class Solution {
    public string DecodeString(string s) {
        var res = new Stack<string>();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ']') {
                string subStr = "";
                while (res.Peek() != "[") {
                    subStr = res.Pop() + subStr;
                }
                res.Pop();
                string digits = "";
                while (res.Count != 0 && char.IsDigit(res.Peek()[0])) {
                    digits = res.Pop() + digits;
                }
                string str = "";
                int times = int.Parse(digits);
                while (times > 0) {
                    str += subStr;
                    times--;
                }
                res.Push(str);
            }
            else res.Push(s[i].ToString());
        }
        return string.Join("", res.Reverse());
    }
}
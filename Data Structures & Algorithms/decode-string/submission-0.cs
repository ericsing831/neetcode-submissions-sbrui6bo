public class Solution {
    public string DecodeString(string s) {
        var stack = new Stack<string>();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] != ']')
                stack.Push(s[i].ToString());
            else {
                string subStr = "";
                while (stack.Peek() != "[") {
                    subStr = stack.Pop() + subStr;
                }
                stack.Pop();

                string time = "";
                while (stack.Count > 0 && int.TryParse(stack.Peek(), out int num)) {
                    time = stack.Pop() + time;
                }
                int k = int.Parse(time);
                while (k > 0) {
                    stack.Push(subStr);
                    k--;
                }
            }
        }
        return string.Join("", stack.Reverse());
    }
}
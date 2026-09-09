public class Solution {
    
    public string DecodeString(string s) {
        Stack<string> stack = new Stack<string>();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ']') {
                string str = "";
                while (stack.Peek() != "[") {
                    str = stack.Pop() + str;
                }
                stack.Pop();
                string timeStr = "";
                while (stack.Count > 0 && int.TryParse(stack.Peek(), out int num)) {
                    timeStr = stack.Pop() + timeStr;
                }
                int time = int.Parse(timeStr);
                string subStr = "";
                for (int k = 0; k < time; k++) {
                    subStr += str;
                }
                stack.Push(subStr);
            }
            else stack.Push(s[i].ToString());
        }
        return string.Join("", stack.Reverse()); 
    }
} 
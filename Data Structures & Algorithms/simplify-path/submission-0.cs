public class Solution {
    public string SimplifyPath(string path) {
        int fast = 0, slow = 0;
        var resStack = new Stack<string>();
        while (slow < path.Length) {
            if (path[slow] == '/') {
                fast = slow + 1;
                while (fast < path.Length && path[fast] != '/') {
                    fast++;
                }
                if (path[(slow + 1)..(fast)] == "..") {
                    if (resStack.Count > 0) 
                        resStack.Pop();
                }
                else if (path[(slow + 1)..(fast)] != "" && path[(slow + 1)..(fast)] != ".") 
                    resStack.Push(path[(slow + 1)..(fast)]);
                
                slow = fast;
            }
        }
        string res = "/" + String.Join('/', resStack.Reverse());
        return res;
    }
}
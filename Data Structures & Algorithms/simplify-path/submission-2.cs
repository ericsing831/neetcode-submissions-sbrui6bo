public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();
        int i = 0;
        int j = 0;
        while (i < path.Length) {

            if (path[i] == '/') {
                i++;
                continue;
            }

            j = i;
            while (j < path.Length && path[j] != '/') {
                j++;
            }
            if (path[i..j] == "..") {
                if (stack.Count > 0) 
                    stack.Pop();
            }
            else if (path[i..j] != ".") {
                stack.Push(path[i..j]);
            }
            i = j;
        }
        return "/" + string.Join("/", stack.Reverse());
    }
}
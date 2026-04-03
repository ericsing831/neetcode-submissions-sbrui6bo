public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach (string str in tokens) {
            if (int.TryParse(str, out int num)) {
                stack.Push(num);
            }
            else {
                int a, b;
                switch (str)
                {
                    case "+":
                        a = stack.Pop();
                        b = stack.Pop();
                        stack.Push(a + b);
                        break;
                    case "-":
                        a = stack.Pop();
                        b = stack.Pop();
                        stack.Push(b - a);
                        break;   
                    case "*":
                        a = stack.Pop();
                        b = stack.Pop();
                        stack.Push(a * b);
                        break;
                    case "/":
                        a = stack.Pop();
                        b = stack.Pop();
                        stack.Push(b / a);
                        break;
                }
            }
        }
        return stack.Pop();
    }
}

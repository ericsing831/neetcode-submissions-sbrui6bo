public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        foreach (string operation in operations) {
            if (int.TryParse(operation, out int num)) {
                stack.Push(num);
            }
            else if (operation == "C") {
                stack.Pop();
            }
            else if (operation == "D") {
                stack.Push((2 * stack.Peek()));
            }
            else if (operation == "+") {
                var val1 = stack.Pop();
                var val2 = stack.Pop();
                stack.Push(val2);
                stack.Push(val1);
                var val3 = val1 + val2;
                stack.Push(val3);
            }
        }
        int sum = 0;
        while (stack.Count != 0) {
            sum += stack.Pop();
        }
        return sum;
    }
}
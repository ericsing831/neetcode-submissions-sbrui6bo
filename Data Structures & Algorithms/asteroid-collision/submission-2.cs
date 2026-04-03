public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();
        foreach (int a in asteroids) {
            int temp = a;
            while (stack.Count != 0 && temp < 0 && stack.Peek() > 0) {
                int diff = temp + stack.Peek();
                if (diff < 0) {
                    stack.Pop();
                }
                else if (diff > 0) {
                    temp = 0; 
                }
                else {
                    temp = 0;
                    stack.Pop();
                }
            }
            if (temp != 0) {
                stack.Push(temp);
            } 
        }
        return stack.Reverse().ToArray();
    }  
}
public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>();
        int index;
        int width;
        int height;
        int area;
        int maxArea = 0;
        int i;
        for (i = 0; i < heights.Length; i++) {
            while (stack.Count != 0 && heights[stack.Peek()] > heights[i]) {
                index = stack.Pop();
                height = heights[index];
                if (stack.Count == 0) 
                    width = i;
                else
                    width = i - stack.Peek() - 1;
                area = width * height;
                maxArea = Math.Max(area, maxArea); 
            }
            stack.Push(i);
        }

        i = heights.Length;
        while (stack.Count != 0) {
            index = stack.Pop();
            height = heights[index];
            if (stack.Count == 0) 
                width = i;
            else
                width = i - stack.Peek() - 1;
            area = width * height;
            maxArea = Math.Max(area, maxArea); 
        }
        return maxArea;
    }
}

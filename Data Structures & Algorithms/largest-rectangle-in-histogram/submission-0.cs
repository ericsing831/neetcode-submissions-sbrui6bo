public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var indexes = new Stack<int>();
        int maxArea = 0;
        int width;
        int height;
        int area;
        int idx;
        int i;
        for (i = 0; i < heights.Length; i++) {
            width = 0;
            while (indexes.Count != 0 && heights[i] < heights[indexes.Peek()]) {
                idx = indexes.Pop();
                if (indexes.Count == 0) 
                    width = i;
                else
                    width = i - indexes.Peek() - 1;
                height = heights[idx];
                area = height * width;
                maxArea = Math.Max(area, maxArea);
            }
            indexes.Push(i);
        }

        i = heights.Length;
        while (indexes.Count != 0) {
            idx = indexes.Pop();
            if (indexes.Count == 0) 
                width = i;
            else
                width = i - indexes.Peek() - 1;
            height = heights[idx];
            area = height * width;
            maxArea = Math.Max(area, maxArea);
        }
        return maxArea;
    }
}

public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        int maxArea = 0;
        int area = 0;
        while (left < right) {
            area = Math.Min(heights[left], heights[right]) * (right - left);
            if (heights[right] > heights[left]) {
                left++;
            }
            else right--;
            maxArea = Math.Max(area, maxArea);
        }
        return maxArea;
    }
}

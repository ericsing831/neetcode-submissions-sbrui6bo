public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxLeft = height[left], maxRight = height[right];
        int water = 0;
        while (left < right) {
            if (maxLeft > maxRight) {
                right--;
                water += (maxRight - height[right]) > 0 ? (maxRight - height[right]) : 0;
                maxRight = Math.Max(maxRight, height[right]);
            }
            else {
                left++;
                water += (maxLeft - height[left]) > 0 ? (maxLeft - height[left]) : 0;
                maxLeft = Math.Max(maxLeft, height[left]);
            }
        }
        return water;
    }
}

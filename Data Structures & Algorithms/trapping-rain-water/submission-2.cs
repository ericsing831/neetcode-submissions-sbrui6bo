public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxLeft = height[left], maxRight = height[right];
        int water = 0;
        while (left < right) {
            if (maxLeft > maxRight) {
                right--;
                maxRight = Math.Max(maxRight, height[right]);
                water += maxRight - height[right];
            }
            else {
                left++;
                maxLeft = Math.Max(maxLeft, height[left]);
                water += maxLeft - height[left];
            }
        }
        return water;
    }
}

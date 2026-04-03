public class Solution {
    public void SortColors(int[] nums) {
        int[] colors = new int[3];
        foreach (int i in nums)
        {
            colors[i]++;
        }
        
        int color = 0;
        int index = 0;
        foreach (int i in colors)
        {
            for (int j = 0; j < i; j++)
            {
                nums[index] = color;
                index++;
            }
            color++;
        }
    }
}
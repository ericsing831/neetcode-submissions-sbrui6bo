public class Solution {
    public void SortColors(int[] nums) {
        int[] colors = new int[3];
        foreach (int i in nums)
        {
            colors[i]++;
        }
        
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < colors[i]; j++)
            {
                nums[index++] = i;
            }
        }
    }
}
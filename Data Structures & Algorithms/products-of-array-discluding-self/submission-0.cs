public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        for (int i = 0, baseVal = 1; i < nums.Length; i++)
        {
            if (i != 0)
            {
                prefix[i] = prefix[i-1] * nums[i-1];
            }
            else
            {
                prefix[i] = baseVal;
            }
        }

        for (int i = nums.Length - 1, baseVal = 1; i >= 0; i--)
        {
            if (i != nums.Length - 1)
            {
                suffix[i] = suffix[i+1] * nums[i+1];
            }
            else
            {
                suffix[i] = baseVal;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = prefix[i] * suffix[i];
        }
        return nums;
    }
}
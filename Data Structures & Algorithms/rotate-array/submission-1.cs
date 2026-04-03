public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        Reverse(0, nums.Length - 1);
        Reverse(0, k - 1);
        Reverse(k, nums.Length - 1);

        void Reverse(int left, int right) {
            while (left < right) {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
        }
    }
}
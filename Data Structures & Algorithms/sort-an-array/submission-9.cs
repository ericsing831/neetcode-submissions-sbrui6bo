public class Solution {
    public int[] SortArray(int[] nums) {
        int s = 0, e = nums.Length - 1;
        return MergeSort(nums, s, e);
    }

    public int[] MergeSort(int[] nums, int s, int e) {
        if ((e - s + 1) <= 1) {
            return nums;
        }    
        int m = (s + e) / 2;
        MergeSort(nums, s, m);
        MergeSort(nums, m + 1, e);
        Merge(nums, s, m, e);
        return nums;
    }

    public void Merge(int[] nums, int start, int middle, int end) {
        var left = nums[start..(middle+1)];
        var right = nums[(middle+1)..(end+1)];
        int i = start, j = 0, k = 0;

        while (j < left.Length && k < right.Length) {
            if (left[j] <= right[k]) {
                nums[i] = left[j];
                j++;
            }
            else {
                nums[i] = right[k];
                k++;
            }
            i++;
        }
        while (j < left.Length) {
            nums[i] = left[j];
            j++;
            i++;
        }
        while (k < right.Length) {
            nums[i] = right[k];
            k++;
            i++;
        }
    }
}
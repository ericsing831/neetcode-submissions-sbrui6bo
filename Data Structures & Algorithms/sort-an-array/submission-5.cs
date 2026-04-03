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
        int[] arr = new int[end - start + 1];
        int i = start, j = middle + 1;
        for (int s = 0; s < end - start + 1; s++) {
            if (i <= middle && j <= end) {
                if (nums[i] > nums[j]) {
                    arr[s] = nums[j];
                    j++;
                }
                else {
                    arr[s] = nums[i];
                    i++;
                }
            }
            else if (i > middle && j <= end) {
                arr[s] = nums[j];
                j++;
            }
            else if (i <= middle && j > end) {
                arr[s] = nums[i];
                i++;
            }
        }
        for (int x = 0; x < arr.Length; x++) {
            nums[start + x] = arr[x];
        }
    }
}
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach (int[] arr in matrix) {
            int left = 0, right = arr.Length - 1;

            if (arr[right] < target) {
                continue;
            }

            if (arr.Length == 1) {
                if (arr[0] == target) return true;
                else continue;
            }

            while (left <= right) {
                int mid = (left + right) / 2;
                if (arr[mid] > target) {
                    right = mid - 1;
                }
                else if (arr[mid] < target) {
                    left = mid + 1;
                }
                else return true;
            }

        }
        return false;
    }
}

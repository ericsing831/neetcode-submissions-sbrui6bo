public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0, right = arr.Length - k;
        while (left < right) {
            int mid = (left + right) / 2;
            // distance of arr[mid + k] to x < distance of arr[mid] to x
            if (x - arr[mid] > arr[mid + k] - x) {
                // ditch all elements <= arr[mid]
                left = mid + 1;
            }
            // distance of arr[mid + k] to x > distance of arr[mid] to x 
            else {
                // index from mid+1, mid+2,...mid+k-1 as a left boundary of search range is not valid, cause its right boudary will be mid+k+1, mid+k+2  
                // only the start index which is mid is a valid left boundary of search range for range (mid ---......--- arr.Length)
                right = mid;
            }
        }
        return arr[left..(left+k)].ToList();
    }
}
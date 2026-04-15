public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0;
        var res = new List<int>();
        for (int right = 0; right < arr.Length; right++) {
            int lDiff = Math.Abs(arr[left] - x);
            int rDiff = Math.Abs(arr[right] - x);
            // what make this window not valid?
            while ((right - left + 1) > k) {
                // left is close to x than right
                if (lDiff < rDiff || (lDiff == rDiff && arr[left] < arr[right])) {
                    res = arr[left..right].ToList();
                    return res;
                }
                else 
                    left++;
            } 
        }
        res = arr[left..].ToList();
        return res;    }
}
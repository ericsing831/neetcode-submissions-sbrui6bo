public class Solution {
    private int[] prefixSum;
    private Random random = new Random();
    private int[] _w;
    public Solution(int[] w) {
        _w = new int[w.Length];
        Array.Copy(w, _w, w.Length);
        prefixSum = new int[_w.Length];
        int sum = 0;

        for (int i = 0; i < w.Length; i++) {
            sum += w[i];
            prefixSum[i] = sum; 
        }
    }
    
    public int PickIndex() {
        int rW = random.Next(1, prefixSum[^1] + 1);
        int left = 0;
        int right = prefixSum.Length - 1;

        while (left < right) {
            int mid = (left + right) / 2;
            if (prefixSum[mid] >= rW) {
                right = mid;
            }
            else {
                left = mid + 1;
            }
        }
        return left;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */
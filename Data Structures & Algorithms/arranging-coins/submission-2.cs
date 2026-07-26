public class Solution {
    public int ArrangeCoins(int n) {
        int count = 0;
        for (int i = 1; i <= n; i++) {
            n = n - i;
            if (n < 0) {
                break;
            }
            count++;
            if (n == 0) break;
        }
        return count;
    }
}
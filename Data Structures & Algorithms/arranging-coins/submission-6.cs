public class Solution {
    public int ArrangeCoins(int n) {
        long left = 0;
        long right = n;
        while (left <= right) {
            long mid = (left - right) / 2 + right;
            long coins = mid * (mid + 1) / 2;

            if (coins == n) {
                return (int)mid;
            }
            else if (coins > n) {
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }
        return (int)left - 1;
    }
}
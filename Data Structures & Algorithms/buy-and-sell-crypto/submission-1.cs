public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        for (int i = 0; i < prices.Length; i++) {
            for (int j = i + 1; j < prices.Length; j++) {
                int temp = prices[j] - prices[i];
                profit = Math.Max(temp, profit);
            }
        }
        return profit;
    }
}

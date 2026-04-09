public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = prices[0];
        int maxP = 0;
        foreach (int sell in prices) {
            int profit = sell - minBuy;
            maxP = Math.Max(profit, maxP);
            if (sell < minBuy) {
                minBuy = sell;
            }
        }
        return maxP;
    }
}

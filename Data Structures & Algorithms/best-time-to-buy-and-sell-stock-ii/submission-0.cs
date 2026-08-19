public class Solution {
    public int MaxProfit(int[] prices) {
        //[7,1,5,3,6,4]
        int curr = prices[0];
        int totalProfit = 0;
        for (int i = 0; i < prices.Length; i++) {
            int sell = prices[i];
            totalProfit += Math.Max(0, sell - curr);
            
            if (sell != curr) 
                curr = sell;
        }
        return totalProfit;
    }
}
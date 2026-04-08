public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = weights.Max(), r = weights.Sum();
        int res = 0;
        int i = 0;
        while (l <= r) {
            int m = (l + r) / 2;

            int cap = m;
            int d = 1;
            bool canShip;
            foreach (int weight in weights) {
                //reset
                if (cap < weight) { 
                    d++;
                    if (d > days) break;
                    cap = m;
                }
                cap -= weight;
            }
            canShip = (d <= days);

            if (canShip) {
                // update res
                res = m;
                // shift left to find limit
                r = m - 1;
            }
            else {
                l = m + 1;
            }
        }
        return res;
    }
}
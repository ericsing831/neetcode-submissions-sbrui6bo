public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max();
        int res = r;
        while (l <= r) {
            int m = (l + r) / 2;
            int totalHrs = 0;
            foreach (int p in piles) {
                totalHrs += (int)Math.Ceiling((double)p / m);
            }

            if (totalHrs <= h) {
                r = m - 1;
                res = Math.Min(m, res);
            }
            else {
                l = m + 1;
            }
        }
        return res;
    }
}

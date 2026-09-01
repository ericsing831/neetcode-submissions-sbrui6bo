public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        (int pos, int spd)[] cars = new (int pos, int spd)[n];
        for (int i = 0; i < n; i++) {
            cars[i].pos = position[i];
            cars[i].spd = speed[i];
        }
        Array.Sort(cars, (a, b) => b.pos.CompareTo(a.pos));

        var fleets = new Stack<double>();
        for (int i = 0; i < n; i++) {
            double temp = (double)(target - cars[i].pos) / cars[i].spd;
            if (fleets.Count == 0 || fleets.Peek() < temp) {
                fleets.Push(temp);
            }
        }
        return fleets.Count;
    }
}

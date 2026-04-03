public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int left = 0, right = people.Length - 1;
        Array.Sort(people);
        int boatCount= 0;
        while (left < right) {
            if (people[left]+people[right] > limit) {
                right--;
            } 
            else if (people[left]+people[right] <= limit) {
                boatCount++;
                people[left] = 0;
                people[right] = 0;
                left++;
                right--;
            }
        }
        foreach (int weight in people) {
            if (weight <= limit && weight != 0) {
                boatCount++;
            }
        }
        return boatCount++;
    }
}
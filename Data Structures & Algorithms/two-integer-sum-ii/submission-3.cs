public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;
        while (j > i) {
            if (numbers[i]+numbers[j] > target) {
                j--;
                continue;
            }
            else if (numbers[i]+numbers[j] < target) {
                i++;
                continue;
            }
            else 
                return new int[] {i+1, j+1};
        } 
        return new int[0];
    }
}

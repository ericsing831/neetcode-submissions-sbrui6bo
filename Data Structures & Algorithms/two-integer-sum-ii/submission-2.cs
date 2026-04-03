public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        while (i < numbers.Length) {
            int leftnum = target - numbers[i];
            for (int j = 0; j < numbers.Length; j++) {
                if (i == j) {
                    continue;
                }
                if (leftnum == numbers[j]) {
                    return new int[] {i+1, j+1};
                }
            }
            i++;
        }
        return new int[0];
    }
}

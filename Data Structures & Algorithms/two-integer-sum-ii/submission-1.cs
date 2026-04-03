public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++) {
            int left = target - numbers[i];
                
            if (dict.ContainsKey(numbers[i])) {
                return new int[] {dict[numbers[i]]+1, i+1};
            }
            dict[left] = i;
        }
        return new int[0];
    }
}

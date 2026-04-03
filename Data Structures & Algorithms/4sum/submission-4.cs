public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {

        Array.Sort(nums);
        var res = new List<List<int>>();
        var quad = new List<int>();

        void kSum(int k, int start,long target) {
            if (k != 2) {
                for (int i = start; i < nums.Length - k + 1; i++) {
                    if (i > start && nums[i] == nums[i-1]) continue;
                    quad.Add(nums[i]);
                    kSum(k - 1, i + 1, target - nums[i]);
                    quad.RemoveAt(quad.Count - 1);
                }
                return;
            }
            int left = start, right = nums.Length - 1;
            while (left < right) {
                long sum = (long)nums[left] + nums[right];
                if (sum > target) {
                    right--;
                }
                else if (sum < target) {
                    left++;
                }
                else {
                    var newQuad = new List<int>(quad);
                    newQuad.Add(nums[left]);
                    newQuad.Add(nums[right]);
                    res.Add(newQuad);
                    left++;
                    while (left < right && nums[left] == nums[left- 1]) {
                        left++;
                    }

                }
            }
        }

        kSum(4, 0, target);
        return res;
    }
}
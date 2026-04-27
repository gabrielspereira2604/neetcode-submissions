public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];

            if (dict.ContainsKey(difference)) {
                return new int[] { dict[difference], i };
            }

            dict[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}

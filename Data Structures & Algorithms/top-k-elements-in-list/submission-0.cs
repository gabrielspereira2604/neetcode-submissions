public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = nums.GroupBy(x => x)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count)
            .Select(x => x.Value)
            .Take(k);

        return freq.ToArray();
    }
}

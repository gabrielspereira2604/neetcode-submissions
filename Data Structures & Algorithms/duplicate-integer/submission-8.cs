public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numsHashList = new HashSet<int>(nums);
        return nums.Count() != numsHashList.Count();
    }
}
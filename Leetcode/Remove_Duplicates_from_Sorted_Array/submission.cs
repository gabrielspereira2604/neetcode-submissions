public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || !nums.Any()) return 0;

        var k = 1;
        for (int i = 1; i < nums.Count(); i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
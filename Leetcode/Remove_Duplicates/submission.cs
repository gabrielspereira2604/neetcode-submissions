public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums == null || nums.Length == 0) return 0;

        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            if (nums[l] == val)
            {
                nums[l] = nums[r];
                r--;
            }
            else
            {
                l++;
            }
        }

        return l;
    }
}

// 3, 3
// 3, 2
// 
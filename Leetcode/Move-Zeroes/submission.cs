public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        if (nums.Length <= 1) return;
        int r = 1;

        for (int l = 0; l < nums.Length - 1; l++)
        {
            if (nums[l] == 0)
            {
                while (r < nums.Length && nums[r] == 0)
                {
                    r++;
                }

                if (r == nums.Length) break;

                nums[l] = nums[r];
                nums[r] = 0;
            }

            r++;
        }
    }
}
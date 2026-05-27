public class Solution
{
    public int MaxArea(int[] height)
    {
        int l = 0;
        int r = height.Count() - 1;
        int maxArea = 0;

        while (l != r)
        {
            int x = r - l;
            int y = Math.Min(height[l], height[r]);
            int area = x * y;

            maxArea = Math.Max(maxArea, area);

            if (height[l] > height[r])
            {
                r--;
            }
            else
            {
                l++;
            }
        }


        return maxArea;
    }
}
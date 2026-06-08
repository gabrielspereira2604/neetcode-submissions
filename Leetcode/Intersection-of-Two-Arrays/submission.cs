public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        { // Inverte para alocar o menor array no HashSet
            return Intersection(nums2, nums1);
        }

        var set1 = new HashSet<int>(nums1);
        var result = new HashSet<int>();

        foreach (int num in nums2)
        {
            if (set1.Contains(num))
            {
                result.Add(num);
            }
        }

        return result.ToArray();
    }
}
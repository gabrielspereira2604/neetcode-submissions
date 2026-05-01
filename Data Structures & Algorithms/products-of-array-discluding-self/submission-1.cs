public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int zeroCount = 0;
        foreach(var num in nums){
            if(num == 0) {
                zeroCount++;
            }else{
                product *= num;
            }
        }

        if(zeroCount > 1){
            return new int[nums.Length];
        }

        return nums
            .Select(x => zeroCount == 0 ? product / x : (x == 0 ? product : 0))
            .ToArray();
    }
}

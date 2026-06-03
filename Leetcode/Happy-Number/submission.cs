public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = SumOfSquares(n);
        }

        return n == 1;
    }

    private int SumOfSquares(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int d = num % 10;
            sum += d * d;
            num /= 10;
        }

        return sum;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.AlternatingSum([1, 3, 5, 7]);
        Console.WriteLine(caseOne);

        var caseTwo = s.AlternatingSum([100]);
        Console.WriteLine(caseTwo);
    }
}

public class Solution
{
    public int AlternatingSum(int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum += nums[i];
            }
            else
            {
                sum -= nums[i];
            }
        }
        return sum;
    }
}
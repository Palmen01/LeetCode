using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.GetConcatenation([1,2,1]);
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.GetConcatenation([1,3,2,1]);
        Console.WriteLine(string.Join(", ", caseTwo));

    }
}

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }

        return ans;
    }
}
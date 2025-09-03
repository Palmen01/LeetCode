using System;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.TwoSum(new int[] { 3, 2, 4 }, 6);
        Console.WriteLine(string.Join(", ", caseTwo));

        var caseThree = s.TwoSum(new int[] { 3, 3 }, 6);
        Console.WriteLine(string.Join(", ", caseThree));

    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[0];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.PivotArray([9, 12, 5, 10, 14, 3, 10], 10);
        Console.WriteLine(caseOne);

        // var caseTwo = s.PivotArray([-3,4,3,2], 2);
        // Console.WriteLine(caseTwo);
    }
}

/// <summary>
/// I have misunderstood the question, will retry another day.
/// https://leetcode.com/problems/partition-array-according-to-given-pivot/description/
/// </summary>

public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        int[] Pi = new int[nums.Length];
        int[] Pj = new int[nums.Length];
        double average = nums.Average();
        int piIndex = 0;
        int pjIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= average)
            {
                Pi[piIndex] = nums[i];
                piIndex++;
            }
            else
            {
                Pj[pjIndex] = nums[i];
                pjIndex++;
            }
        }

        for (int i = 0; i < piIndex; i++)
        {
            nums[i] = Pi[i];
        }
        for (int i = 0; i < pjIndex; i++)
        {
            nums[piIndex + i] = Pj[i];
        }

        return nums;
    }
}
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.TransformArray([4, 3, 2, 1]);
        Console.WriteLine(caseOne);

        var caseTwo = s.TransformArray([1, 5, 1, 4, 2]);
        Console.WriteLine(caseTwo);
    }
}
public class Solution
{
    public int[] TransformArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] % 2 == 0)
            {
                nums[i] = 0;
            }
            else
            {
                nums[i] = 1;
            }

        }
        Array.Sort(nums);
        return nums;
    }
}
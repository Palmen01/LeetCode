public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.NumIdenticalPairs([1,2,3,1,1,3]);
        Console.WriteLine(caseOne);

        var caseTwo = s.NumIdenticalPairs([1,1,1,1]);
        Console.WriteLine(caseTwo);

        var caseThree = s.NumIdenticalPairs([1,2,3]);
        Console.WriteLine(caseThree);
    }
}

public class Solution {
    public int NumIdenticalPairs(int[] nums) {

        int pair = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && i < j)
                {
                    pair += 1;
                }
            }
        }
        return pair;
    }
}
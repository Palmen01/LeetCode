public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.Shuffle([2,5,1,3,4,7], 3);
        Console.WriteLine(caseOne);

        // var caseTwo = s.Shuffle([1,2,3,4,4,3,2,1], 4);
        // Console.WriteLine(caseTwo);

        // var caseThree = s.Shuffle([1,1,2,2], 2);
        // Console.WriteLine(caseThree);
    }
}

public class Solution {
    public int[] Shuffle(int[] nums, int n) {

        int[] ans = new int[nums.Length];
        int ansIdx = 0;

        for (int i = 0; i < nums.Length / 2; i++)
        {
            ans[ansIdx] = nums[i];
            ansIdx++;
            ans[ansIdx] = nums[i + n];
            ansIdx++;
        }
        return ans;
    }
}
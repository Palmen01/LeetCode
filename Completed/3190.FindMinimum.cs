using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.MinimumOperations([1,2,3,4]);
        Console.WriteLine(caseOne);

        var caseTwo = s.MinimumOperations([3,6,9]);
        Console.WriteLine(caseTwo);
    }
}

public class Solution {
    public int MinimumOperations(int[] nums) {
        int count = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 3 != 0)
            {
                count++;
            }
        }
        return count;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.MaximumWealth([[1, 2, 3], [3, 2, 1]]);
        Console.WriteLine(caseOne);

        var caseTwo = s.MaximumWealth([[1, 5], [7, 3], [3, 5]]);
        Console.WriteLine(caseTwo);

        var caseThree = s.MaximumWealth([[2, 8, 7], [7, 1, 3], [1, 9, 5]]);
        Console.WriteLine(caseThree);
    }
}

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int wealth = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                wealth += accounts[i][j];
            }

            if (wealth > maxWealth)
            {
                maxWealth = wealth;
            }
        }
        return maxWealth;
    }
}
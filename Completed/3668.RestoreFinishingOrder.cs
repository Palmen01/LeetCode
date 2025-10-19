public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.RecoverOrder([3, 1, 2, 5, 4], [1, 3, 4]);
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.RecoverOrder([1, 4, 5, 3, 2], [2, 5]);
        Console.WriteLine(string.Join(", ", caseTwo));
    }
}

public class Solution
{
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        int[] ans = new int[friends.Length];
        int x = 0;

        for (int i = 0; i < order.Length; i++)
        {
            if (friends.Contains(order[i]))
            {
                ans[x++] = order[i];
            }
        }
        return ans;
    }
}
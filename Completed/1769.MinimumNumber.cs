using System;
public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.MinOperations("110");
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.MinOperations("001011");
        Console.WriteLine(string.Join(", ", caseTwo));

    }
}

public class Solution
{
    public int[] MinOperations(string boxes)
    {
        int n = boxes.Length;
        int[] ans = new int[n];

        for (int i = 0; i < n; i++)
        {
            int operations = 0;
            for (int j = 0; j < n; j++)
            {
                if (boxes[j] == '1')
                {
                    operations += Math.Abs(i - j);
                }
            }
            ans[i] = operations;
        }
        return ans;
    }
}

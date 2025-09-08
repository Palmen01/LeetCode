using System;
public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.DifferenceOfSums(10, 3);
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.DifferenceOfSums(5, 6);
        Console.WriteLine(string.Join(", ", caseTwo));

        var caseThree = s.DifferenceOfSums(5, 1);
        Console.WriteLine(string.Join(", ", caseThree));

    }
}
public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int DividableSum = 0;
        int NonDividableSum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0)
            {
                DividableSum += i;
            }
            else
            {
                NonDividableSum += i;
            }
        }
        return NonDividableSum - DividableSum;
    }
}
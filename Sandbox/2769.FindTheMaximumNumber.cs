using System;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();

        var caseOne = s.TheMaximumAchievableX(4, 1);
        Console.WriteLine($"Case One: {caseOne}");

        var caseTwo = s.TheMaximumAchievableX(3, 2);  
        Console.WriteLine($"Case Two: {caseTwo}");
    }
}

public class Solution 
{
    public int TheMaximumAchievableX(int num, int t) 
    {
        return num + 2 * t;
    }
}
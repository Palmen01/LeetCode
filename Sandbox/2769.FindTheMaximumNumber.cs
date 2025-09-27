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
        // TODO: Implement the logic here
        
        // This is a placeholder implementation
        return num + 2 * t; // Common pattern for "maximum achievable X" problems
    }
}
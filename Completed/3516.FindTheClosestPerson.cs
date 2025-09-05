using System;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.FindClosest(2, 7, 4);
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.FindClosest(2, 5, 6);
        Console.WriteLine(string.Join(", ", caseTwo));

        var caseThree = s.FindClosest(1, 5, 3);
        Console.WriteLine(string.Join(", ", caseThree));

    }
}

public class Solution
{
    public int FindClosest(int x, int y, int z)
    {
        int xDistance = Math.Abs(z - x);

        int yDistance = Math.Abs(z - y);

        if (xDistance < yDistance) return 1;
        else if (yDistance < xDistance) return 2;
        return 0;
    }
}
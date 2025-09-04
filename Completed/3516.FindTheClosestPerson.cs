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
        int xDistance = z - x;
        int yDistance = z - y;

        if (xDistance < 0)
        {
            xDistance -= xDistance * 2;
        }
        
        if (yDistance < 0)
        {
            yDistance -= yDistance * 2;
        }

        if (xDistance < yDistance)
        {
            return 1;
        }
        else if (yDistance < xDistance)
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }
}

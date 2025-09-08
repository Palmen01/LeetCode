using System;
public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.BuildArray([0,2,1,5,3,4]);
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.BuildArray([5,0,1,2,3,4]);  
        Console.WriteLine(string.Join(", ", caseTwo));
    }
}
public class Solution {
    public int[] BuildArray(int[] nums) {
        
    }
}
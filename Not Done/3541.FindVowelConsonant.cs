public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.MaxFreqSum("successes");
        Console.WriteLine(caseOne);

        // var caseTwo = s.MaxFreqSum("aeiaeia");
        // Console.WriteLine(caseTwo);
    }
}

public class Solution
{
    public int MaxFreqSum(string s)
    {
        
        string vowels = "aeiou";
        var freq = new Dictionary<char, int>();

        foreach (var ch in s)
        {
            
        }

        int vowelMax = 0;
        int consonantMax = 0;

        return;
    }
}
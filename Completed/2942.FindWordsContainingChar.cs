using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        string[] words1 = { "leet", "code" };
        char x1 = 'e';
        var result1 = sol.FindWordsContaining(words1, x1);
        Console.WriteLine("Output: [" + string.Join(",", result1) + "]");

        string[] words2 = { "abc", "bcd", "aaaa", "cbc" };
        char x2 = 'a';
        var result2 = sol.FindWordsContaining(words2, x2);
        Console.WriteLine("Output: [" + string.Join(",", result2) + "]");

        string[] words3 = { "abc", "bcd", "aaaa", "cbc" };
        char x3 = 'z';
        var result3 = sol.FindWordsContaining(words3, x3);
        Console.WriteLine("Output: [" + string.Join(",", result3) + "]");
    }
}

public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        List<int> ans = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                ans.Add(i);
            }
        }
        return ans;
    }
}
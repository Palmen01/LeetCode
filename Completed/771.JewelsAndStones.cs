public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.NumJewelsInStones("aA", "aAAbbbb");
        Console.WriteLine(caseOne);

        var caseTwo = s.NumJewelsInStones("z", "ZZ");
        Console.WriteLine(caseTwo);
    }
}

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;
        for (int i = 0; i < jewels.Length; i++)
        {
            for (int j = 0; j < stones.Length; j++)
            {
                if (jewels[i] == stones[j])
                {
                    count++;
                }
            }
        }
        return count;
    }
}
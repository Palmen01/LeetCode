public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.DefangIPaddr("1.1.1.1");
        Console.WriteLine(caseOne);

        var caseTwo = s.DefangIPaddr("255.100.50.0");
        Console.WriteLine(caseTwo);
    }
}

public class Solution {
    public string DefangIPaddr(string address)
    {
        string fang = address.Replace(".", "[.]");

        return fang;
    }
}
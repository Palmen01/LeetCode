using System;
public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        var caseOne = s.ConvertTemperature(36.5);
        Console.WriteLine(string.Join(", ", caseOne));

        var caseTwo = s.ConvertTemperature(122.11);
        Console.WriteLine(string.Join(", ", caseTwo));

    }
}
public class Solution {
    public double[] ConvertTemperature(double celsius)
    {
        double kelvin = celsius + 273.15;
        double fahrenheit = celsius * 1.80 + 32.00;
        return [kelvin, fahrenheit];
    }
}
using System;

public class SimpleInterest
{
    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return principal * rate * time / 100;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(CalculateSimpleInterest(1000, 5, 2));
    }
}
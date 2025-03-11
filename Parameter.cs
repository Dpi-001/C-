using System;

public class Parameter
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2));
    }
}
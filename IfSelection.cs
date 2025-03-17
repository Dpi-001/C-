using System;

public class IfSelection
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        // If statement to check if a is greater than b
        if (a > b)
        {
            Console.Write("a is greater than b");
        } 
        Console.Write("a is not greater than b");
    }
}
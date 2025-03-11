using System;

public class RecursionFactorial
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The factorial of " + n + " is " + Factorial(n));
    }
    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
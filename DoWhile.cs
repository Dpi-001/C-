using System;

public class DoWhileLoop
{
    public static void Main(string[] args)
    {
        int i = 1;
        do
        {
            Console.WriteLine("Value of i: {0}", i);
            i++;
        } while (i <= 5);
    }
}
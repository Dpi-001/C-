/* *****
    ****
    ***
    **
    *
    */


using System;

public class Pattern4
{
    public static void Main()
    {
        int n = 5; // Number of rows

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
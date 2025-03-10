using System;

public class ArraySum
{
    public static void Main()
    {
        int [] a = new int[5];
        int sum = 0, n, i;
        Console.WriteLine("Enter the number of elements in the array: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the elements of the array: ");
        for(i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(i = 0; i < n; i++)
        {
            sum = sum + a[i];
        }
        Console.WriteLine("The sum of the elements of the array is: " + sum);
    }
}
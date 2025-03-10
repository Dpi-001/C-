using System;

public class Stringcomparision
{
    public static void Main(string[] args)
    {
        string str1, str2;
        Console.WriteLine("Enter the first string");
        str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string");
        str2 = Console.ReadLine();
      int result = str1.CompareTo(str2);
        if (result == 0)
        {
            Console.WriteLine("Both strings are equal.");
        }
        else if (result < 0)
        {
            Console.WriteLine("First string is less than second string.");
        }
        else
        {
            Console.WriteLine("First string is greater than second string.");
        }
        Console.ReadKey();
    }
} 

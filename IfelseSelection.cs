using System;

public class IfelseSelection
{
    public void IfElse()
    {
        Console.WriteLine("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());
  // even odd
        if (a % 2 == 0)
        {
            Console.WriteLine("a is even");
        }
        else
        {
            Console.WriteLine("a is odd");
        }
    }
    public static void Main(string[] args)
    {
        IfelseSelection s = new IfelseSelection();
        s.IfElse();
    }
}
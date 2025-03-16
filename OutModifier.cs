using System;

public class OutModifier
{
    static void Pass(int a,int b,out int x,out int y)
    {
        x = a;| // x is assigned the value of a
        y = b; // y is assigned the value of b
    }
    static void Main()
    {
       int x, y;
       Pass(10, 20, out x, out y);
       Console.WriteLine(x); // Output: 10
         Console.WriteLine(y); // Output: 20
    }
}
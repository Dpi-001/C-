using System;

public class Stat
{
    public void decalaration()
    {
        int a = 10;
        int b = 20;
        string s = "Hello World";
        bool flag = true;
        int c = a + b;
        Console.WriteLine("The sum of a and b is: " + c);
        Console.WriteLine("The string is: " + s);
        Console.WriteLine("The flag is: " + flag);
    }
    public void LocalVariable()
    {
        int a = 10;
        int b = 20;
        int c = a + b;
        Console.WriteLine("The sum of a and b is: " + c);
    }
    public void ExpressionStatement()
        {
            int x,y;
            x=1+2;
            x++;
        }
    static void Main()
    {
        Stat s = new Stat();
        s.decalaration();
        s.LocalVariable();
        s.ExpressionStatement();
    }

}
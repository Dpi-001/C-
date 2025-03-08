using System;

public class Arthoperation
{
public static void Main()
{
double num1,num2;

Console.WriteLine("Enter First Number");
num1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Second Number");
num2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Add:"+(num1+num2));
Console.WriteLine("Sub:"+(num1-num2));
Console.WriteLine("Mul:"+(num1*num2));
Console.WriteLine("Div:"+(num1/num2));

Console.WriteLine("Press any key to exit");
Console.ReadKey();
}
}

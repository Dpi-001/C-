using System;

public class Calculate{
    int num1,num2,num3;
    public void GetNumbers(){
        Console.Write("Enter the first number: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number: ");
        num3=Convert.ToInt32(Console.ReadLine());
    }
    public void FindSmallest(){
        int result=(num1<num2)?(num1<num3)?num1:num3:(num2<num3)?num2:num3;
        Console.WriteLine("The smallest number is "+result);
    }
    public void FindLargest(){
        int result=(num1>num2)?(num1>num3)?num1:num3:(num2>num3)?num2:num3;
        Console.WriteLine("The largest number is "+result);
    }
    public static void Main(){
        Calculate obj=new Calculate();
        obj.GetNumbers();
        obj.FindSmallest();
        obj.FindLargest();
    }
}
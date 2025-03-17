using System;

public class Ifelseifselection
{
    public void student()
    {
        Console.WriteLine("Enter your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());
         
         if(marks >= 90)
         {
             Console.WriteLine("Grade A");
         }
         else if(marks >= 80)
         {
             Console.WriteLine("Grade B");
         }
         else if(marks >= 70)
         {
             Console.WriteLine("Grade C");
         }
         else if(marks >= 60)
         {
             Console.WriteLine("Grade D");
         }
         else if(marks >= 40)
         {
             Console.WriteLine("Grade E");
         }
         else 
         {
             Console.WriteLine("Grade F");
         }

    }
    public static void Main(string[] args)
    {
        Ifelseifselection s = new Ifelseifselection();
        s.student();
    }
}
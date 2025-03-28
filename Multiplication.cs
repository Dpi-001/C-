using System;

public class MultiplicationTable
{
    public void MulTable()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nMultiplication Table for " + number + ":");
        Console.WriteLine("===================================");
        for (int i = 1; i <= 10; i++)
        {
          Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }

    public void MulTable1To10()
    {
        Console.WriteLine("\nMultiplication Table from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write(i + " x " + j + " = " + (i * j) + "\n");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        MultiplicationTable table = new MultiplicationTable();
        table.MulTable();
        table.MulTable1To10();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}

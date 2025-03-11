using System;

public class RectangularArray
{
    public static void Main()
    {
        int[,] a= new int[2, 3];
        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(a[i,j] + " ");
            }
            Console.WriteLine();
    }
}
}
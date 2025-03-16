using System;

class ParamModifier
{
    static int Sum(params int[] numbers)
    {
        int sum = 0;
       for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static void Main()
    {
        int total = Sum(1, 2, 3, 4, 5);
        Console.WriteLine(total);
    }
}
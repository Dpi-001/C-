using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List <int> numbers = new List<int>();
        numbers.Add(15);
        numbers.Add(20);
        numbers.Add(25);

        foreach(int num in numbers)
        {
            Console.WriteLine("Numbers:"+num);
        }
    }
}

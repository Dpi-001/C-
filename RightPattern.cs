
// Please name your class Pattern
/*
1
12
123
1234
12345
*/
using System;

class PatternProgram
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

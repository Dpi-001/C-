using System;

public class AlphabeticOrder
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        Console.WriteLine("Enter the words:");
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        // Bubble sort algorithm for strings
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(words[j], words[j + 1], StringComparison.Ordinal) > 0)
                {
                    string temp = words[j];
                    words[j] = words[j + 1];
                    words[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("The words in alphabetic order are:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}

using System;

using System.IO;

class Program
{
    static void Main()
    {
        string path = "example.txt";

        File.WriteAllText(path, "Hello, World!");

        string content = File.ReadAllText(path);
        Console.WriteLine("File Content:"+content);
    }
}
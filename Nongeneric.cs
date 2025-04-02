using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable students = new Hashtable();

        students.Add(101, "John Doe");
        students.Add(102, "Jane Smith");
        students.Add(103, 25);

        foreach (DictionaryEntry entry in students)
        {
       Console.WriteLine("Key:"+entry.Key + ", Value:" + entry.Value);
        }
    }
}
using System;

class Person
{
    string name;
    int age;
    string gender;

    void SetData(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    void DisplayData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
    }

    static void Main()
    {
        Person p = new Person();
        p.SetData("Sudeep", 21, "male");
        p.DisplayData();
    }
}
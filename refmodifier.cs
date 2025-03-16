using System;

public class RefModifier
{
    static void Foo(ref int x)
    {
        x = x + 1;
        Console.WriteLine("Inside Foo: " + x);
    }
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before Foo: " + number);
        Foo(ref number);
        Console.WriteLine("After Foo: " + number);
    }
}
// The ref modifier is used to pass an argument by reference. This means that any changes made to the parameter inside the method will also affect the original variable that was passed in. In this example, the CheckEvenOdd method takes an integer parameter by reference, allowing it to modify the original number variable in the Main method. This can be useful when you want a method to modify the original variable rather than just working with a copy of it.
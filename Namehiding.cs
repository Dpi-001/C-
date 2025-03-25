using System;
namespace Outer
{
    class Displayclass
    {
        public void display()
        {
            Console.WriteLine("Outer display method");
        }
    }
    namespace Inner
    {
        class Displayclass
        {
            public void display()
            {
                Console.WriteLine("Inner display method");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Outer.Displayclass outerDisplay = new Outer.Displayclass();
        outerDisplay.display();

        Outer.Inner.Displayclass innerDisplay = new Outer.Inner.Displayclass();
        innerDisplay.display();
    }
}
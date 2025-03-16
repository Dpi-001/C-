using System;

public class OperatorPrece
{
    public void LeftAssociative()
    {
        int a = 10;
        int b = 20;
        int c = 30;
        int Div = 0;
        Div = a + b / c;
        Console.WriteLine(Div);
        }
            public void RightAssociative()
    {
        int a = 10;
        int b = 20;
        int c = 30;
        int r= 0;
        r= a + b / c;
        Console.WriteLine(r);
        }
        public void NullCoalescing()
        {
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine(y);
        }

        public static void Main()
        {
            OperatorPrece op = new OperatorPrece();
            op.LeftAssociative();
            op.RightAssociative();
            op.NullCoalescing();
        }
}
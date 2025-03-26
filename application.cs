// Application :

// using widgets;

// class Test
// {
//     static void Main()
//     {
//         Widget w = new Widget(); // Error
//     }

extern alias W1;
extern alias W2;
class Test
{
    static void Main()
    {
        W1.Widgets.Widgets w1 = new W1.Widgets.Widget();
        W2.Widgets.Widget w = new W2.Widgets.Widget();
}
}
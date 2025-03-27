using widgets;

Library 1 :

namespace widgets
{
    public class widgets{}
}

Library 2 :
namespace widgets
{
    public class widget{}
}

Application :

using widgets;
// class Test
// {
//     static void Main()
//     {
// widget w = new widget(); // Error
//     }
extern alias w1;
extern alias w2;

class Test
{
    static void Main()
    {
        w1.widgets.widgets w = new w1::widgets.widgets();
        w2.widgets.widget w = new w2::widgets.widget();
    }
}
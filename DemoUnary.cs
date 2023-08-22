using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class DemoUnary
    {
        static void Main(string[]args)
        {
            int a = 2;
            int b = 3;
            int x = ++a + ++b;
            Console.WriteLine(x + " " + a + " " + b); // a=3,b=4,x= -1
            x = a++ - b--;
            Console.WriteLine(x + " " + a + " " + b);//a=4,b=3,a++ - b--=1 , x=1
            x = ++a - b++;// a=5,b= 4, ++a - b++ = 1, x=1


            Console.WriteLine(x + " " + a + " " + b);//
            x = --a - --b - a; // a=4 ,b=3, x=3


            Console.WriteLine(x + " " + a + " " + b);//a=4,b=3,x=4
            x = b++ - a-- + b; //4+3-3=4


            Console.WriteLine(x + " " + a + " " + b);//a=5,b=4,x=5
            x = ++a + ++b - b;//5+4-4= 5

            Console.WriteLine(x + " " + a + " " + b);
        }
    }
}

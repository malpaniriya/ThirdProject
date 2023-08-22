using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class GreatestNumber
    {
        static void Main(string[] args)
        {
            int a = 10, b = 15;
            int result = (a > b) ? a : b;
            Console.WriteLine(result);
            string result2 = (a > b) ? "b is greater number" : " b is greater number";
            Console.WriteLine(result2);
        }
    }
}







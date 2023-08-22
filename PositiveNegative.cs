using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class PositiveNegative
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = num > 0 ? "num is positive" : "number is negative";
            Console.WriteLine(result);

        }
    }
}

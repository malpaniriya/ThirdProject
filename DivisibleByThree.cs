using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class DivisibleByThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = (number % 3 == 0) ? "The number is divisible by 3" : "The number is not divisble by ";
    Console.WriteLine(result);

        }
    }
}
//write code character is uppercase letter or lowercase letter using ternary operator

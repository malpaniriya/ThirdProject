using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    //Accept a number from user & check number is +ve or -ve number → number > 0

    internal class TernaryOperatorEvenOdd
    {

    
    
        static void Main(string[]args)
    {
        
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            string num = (a % 2 == 0) ? "Even number " : " Odd number";
            Console.WriteLine(num);




        }
    }
}

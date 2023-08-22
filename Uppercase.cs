using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class Uppercase
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter a character:");
            char character = Convert.ToChar(Console.ReadLine());
            String lettercase = char.IsUpper(character) ?"Uppercase" : "Lowercase";
            Console.WriteLine($"The character is "+ (lettercase));


        }
    }
}

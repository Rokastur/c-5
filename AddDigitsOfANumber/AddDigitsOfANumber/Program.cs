using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigitsOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a 2 digit number");
            int a = int.Parse(Console.ReadLine());

            int dig1 = a / 10;
            int dig2 = a % 10;

            int sum = dig1 + dig2;

            Console.WriteLine("You have entered {0}. Its made up of digits {1} and {2}. The sum of these digits is {3}",a,dig1,dig2,sum);
            Console.ReadLine();

        }
    }
}

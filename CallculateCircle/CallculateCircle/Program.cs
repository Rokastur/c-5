using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallculateCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter circles radius");
            Double r = Double.Parse(Console.ReadLine());

            Double A = Math.PI * Math.Pow(r, 2);
            Double L = 2 * Math.PI * r;

            Console.WriteLine("Circle has an area of {0} and length of {1}", A,L);
            Console.ReadLine();
        }
    }
}

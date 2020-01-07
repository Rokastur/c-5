using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapValues
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = 5;
            int B = 7;

            Console.WriteLine("A is {0}, B is {1}", A, B);

            (A, B) = (B, A);

            Console.WriteLine("now A is {0} and B is {1}", A, B);
            Console.ReadLine();
        }
    }
}

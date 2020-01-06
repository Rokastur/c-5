using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertNametoUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name");
            String name = Console.ReadLine();
            String uName = name.ToUpper();
            String underName = uName.Replace(" ","_");
            Console.WriteLine(underName);
            Console.ReadLine();
        }
    }
}

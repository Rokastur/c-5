using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateWage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter employees ID... ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("... and the hours worked... ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("... and finally the hourly rate ");
            double r = double.Parse(Console.ReadLine());

            double wage = h * r;
            Console.WriteLine("The employee [ID: {0}] has earned a wage of: {1} euros", ID, wage);
            Console.ReadLine();


        }
    }
}

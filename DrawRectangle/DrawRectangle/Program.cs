using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawRectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter X and Y coordinates... ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another set of coordinates of X and Y... ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a new set of coordinates. The program will tell you if they are inside the area of the rectangle made from the first set of coordinates...");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string inside = ((m > x && m < x1) && (n > y && n < y1)) ? "inside" : "outside";
            // || ((m < x && m > x1) && (n < y && n > y1))
            Console.WriteLine(inside);
            Console.ReadLine();

        }
    }
}

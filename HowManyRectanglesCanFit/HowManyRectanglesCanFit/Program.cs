using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyRectanglesCanFit
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter rectangle side length (x and y) ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            int xx = Convert.ToInt32(x);
            int yy = Convert.ToInt32(y);;

            int Xammount = xx / 2;
            int Yammount = yy / 3;
  

            if (x < 2)
            {
                Console.WriteLine("No rectangles would fit");
            }
            else if  (y < 3)
            {
                Console.WriteLine("No rectangles would fit");
            }
            else
            {
                int n = Xammount * Yammount;
                Console.WriteLine("Inside your rectangle ({0} x {1}) fits {2} rectangle(s) of 2 x 3 dimensions", x, y, n);
            }
            Console.ReadLine();
        }
    }
}

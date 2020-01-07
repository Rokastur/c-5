using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSecondsToHoursMinutesSeconds
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number of seconds");
            int seconds = int.Parse(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(seconds);
            Console.WriteLine("You have entered seconds equivalent to: {0}", time);
            Console.ReadLine();

        }
    }
}

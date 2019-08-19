using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in meters: ");
            double distanceInMeters = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Input hour: ");
            double hoursTaken = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input minutes: ");
            double minutesTaken = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input seconds: ");
            double secondsTaken = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your speed in meters/second is: " + Math.Round(distanceInMeters / (secondsTaken + (minutesTaken * 60) + (hoursTaken * 3600)), 8));
            Console.WriteLine("Your speed in km/h is: " + Math.Round(((float) distanceInMeters / 1000) / ( (float) hoursTaken + ((float)minutesTaken / 60) + ((float)secondsTaken / 3600)), 8));
            Console.WriteLine("Your speed in miles/h is: " + Math.Round((distanceInMeters / 1609) / (hoursTaken + (minutesTaken / 60) + (secondsTaken / 3600)), 8));

            Console.ReadKey();


        }
    }
}

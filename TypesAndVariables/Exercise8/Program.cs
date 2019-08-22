using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var minutesInYear = 60 * 24 * 365;
            Console.WriteLine("Please enter number of minutes below: ");
            String input = Console.ReadLine();

            var years = Convert.ToInt32(input) / minutesInYear;
            var days = (Convert.ToInt32(input) % minutesInYear) / 60 / 24;

            Console.WriteLine($"{ input } minutes is { years } years and { days } days!");
            Console.ReadKey();
        }
    }
}

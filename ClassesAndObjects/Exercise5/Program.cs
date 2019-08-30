using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date dateOne = new Date(12,2,2019);
            
            Console.WriteLine(dateOne.DisplayDate());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter day:");
            int inputDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int inputMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int inputYear = int.Parse(Console.ReadLine());

            Date dateTwo = new Date(inputDay, inputMonth, inputYear);
            Console.WriteLine($"\nDisplay date: {dateTwo.DisplayDate()}");

            Console.WriteLine($"Day: {dateTwo.Day}");
            Console.WriteLine($"Month: {dateTwo.Month}");
            Console.WriteLine($"Year: {dateTwo.Year}");

            Console.WriteLine("\nEnter different day:");
            dateTwo.Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter different month:");
            dateTwo.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter different year:");
            dateTwo.Year = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nUpdated Display date: {dateTwo.DisplayDate()}");

            Console.WriteLine($"New Day: {dateTwo.Day}");
            Console.WriteLine($"New Month: {dateTwo.Month}");
            Console.WriteLine($"New Year: {dateTwo.Year}");

            Console.ReadKey();
        }
    }
}

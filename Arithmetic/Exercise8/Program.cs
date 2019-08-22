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
            Console.WriteLine("Please enter employee's Base pay:");
            double basePay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter employee's Hours worked:");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(SalaryCalculator(basePay, hoursWorked));
            Console.ReadKey();
        }

        static string SalaryCalculator(double basePay, double hoursWorked)
        {
            string result = "";
            if (basePay < 8 || hoursWorked > 60)
            {
                result = "ERROR! Base pay is less than $8 or Hours worked are greater than 60!";
            }
            else if (hoursWorked > 40)
            {
                double salary = (basePay * 40) + ((basePay * 1.5) * (hoursWorked - 40));
                result = $"Employee salary is { salary }!";
            }
            else
            {
                double salary =basePay * hoursWorked;
                result = $"Employee salary is { salary }!";
            }

            return result;
        }
    }
}

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
            Console.WriteLine("Please enter your weight in kg:");
            double inputWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm:");
            double inputHeight = Convert.ToDouble(Console.ReadLine());

            double bmi = GetBmi(inputWeight, inputHeight);
            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is { bmi }, You are underweight!");
            }else if (bmi > 25)
            {
                Console.WriteLine($"Your BMI is { bmi }, You are overweight!");
            }
            else
            {
                Console.WriteLine($"Your BMI is { bmi }, You are optimal weight!");
            }

            Console.ReadKey();
        }

        static double GetBmi(double weight, double height)
        {
            return Math.Round(weight / ((height / 100) * (height / 100)), 2); 
        }
    }
}

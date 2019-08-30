using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(fuelGauge);
            int litersFilled = 0;
            int milesTravelled = 0;

            Console.WriteLine("Please enter liters filled:");
            litersFilled = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter miles travelled:");
            milesTravelled = int.Parse(Console.ReadLine());

            Console.Clear();

            for (var i = 0; i < litersFilled; i++)
            {
                fuelGauge.Fill();
            }
            Console.WriteLine($"Fuel gauge report: {fuelGauge.ReportLevel()}");

            for (int i = 0; i < milesTravelled; i++)
            {
                if (odometer.Increment())
                {
                    odometer.Increment();
                    Console.WriteLine($"Mileage: {odometer.Report()}, Fuel Level: {fuelGauge.ReportLevel()}");
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

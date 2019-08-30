using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers, liters, mileage;

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter liters consumed: ");
            liters = Convert.ToDouble(Console.ReadLine());

            Car car = new Car(startKilometers, liters);
            Car car2 = new Car(100, 45);

            Console.Write("Filling up... Enter mileage:");
            mileage = Convert.ToDouble(Console.ReadLine());


            Console.Write("Filling up... Enter liters filled:");
            liters = Convert.ToDouble(Console.ReadLine());
 

            car.FillUp(mileage, liters);
            car2.FillUp(500, 45);

            Console.WriteLine("Liters per 100 km are " + car.CalculateConsumption() + " GasHog: " + car.GasHog() + " / EconomyCar: " + car.EconomyCar());
            Console.WriteLine("Liters per 100 km are " + car2.CalculateConsumption() + " GasHog: " + car2.GasHog() + " / EconomyCar: " + car2.EconomyCar());

            Console.Write("Filling up... Enter 2nd mileage:");
            mileage = Convert.ToDouble(Console.ReadLine());


            Console.Write("Filling up... Enter 2nd liters filled:");
            liters = Convert.ToDouble(Console.ReadLine());


            car.FillUp(mileage, liters);
            car2.FillUp(1000, 80);

            Console.WriteLine("Liters per 100 km are " + car.CalculateConsumption() + " GasHog: " + car.GasHog() + " / EconomyCar: " + car.EconomyCar());
            Console.WriteLine("Liters per 100 km are " + car2.CalculateConsumption() + " GasHog: " + car2.GasHog() + " / EconomyCar: " + car2.EconomyCar());
            Console.ReadKey();
        }
    }
}

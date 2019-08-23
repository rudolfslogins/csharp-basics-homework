using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {

            int cars = 100;
            int seatsInACar = 4;
            int drivers = 30;
            int passengers = 100;
            int carsDriven = drivers;
            int carsNotDriven = cars - drivers;        
            double carpoolCapacity = carsDriven * seatsInACar;
            double averagePassengersPerCar = passengers / carsDriven;

            Console.WriteLine($"There are { cars } cars available.");
            Console.WriteLine($"There are only { drivers } drivers available.");
            Console.WriteLine($"There will be { carsNotDriven } empty cars today.");
            Console.WriteLine($"We can transport { carpoolCapacity } people today.");
            Console.WriteLine($"We have { passengers } to carpool today.");
            Console.WriteLine($"We need to put about { averagePassengersPerCar.ToString("0.##") } in each car.");
            Console.ReadKey();
        }

    }
}
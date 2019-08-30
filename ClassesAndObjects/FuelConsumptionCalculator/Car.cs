using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers; // Starting odometer reading
        //private double _endKilometers; // Ending odometer read
        private double _liters; // Liters of gas used between the readings
        private double _mileage;

        public Car(double startOdo, double liters)
        {
            _startKilometers = startOdo;
            //_endKilometers = endingOdo;
            _liters = liters;
            _mileage = 0;
        }

        public double CalculateConsumption()
        {
           return Math.Round(100 / ((_mileage - _startKilometers) / _liters), 2);
        }

        public bool GasHog()
        {
            if (CalculateConsumption() > 15.0)
            {
                return true;
            }

            return false;
        }

        public bool EconomyCar()
        {
            if (CalculateConsumption() < 5.0)
            {
                return true;
            }

            return false;
        }


        public void FillUp(double mileage, double liters)
        {
            _liters = liters;
            _mileage = mileage;
        }
    }
}
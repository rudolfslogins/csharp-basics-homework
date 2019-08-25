﻿using System;

namespace Exercise3
{
    public class Odometer
    {
        private int _mileage;
        private const int _maxMileage = 999999;
        private const int _minMileage = 0;
        private FuelGauge _fuelGauge;

        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }

        public int Report()
        {
            return _mileage;
        }

        public bool Increment()
        {
            bool success = true;
            if (_fuelGauge.ReportLevel() > 0)
            {
                if (_mileage < _maxMileage)
                {
                    _mileage++;

                }
                else
                {
                    _mileage = 0;
                }
                if (_mileage % 10 == 0)
                {
                    _fuelGauge.DecreaseLevel();
                }
            }
            else
            {
                //throw new Exception($"fuel level: {_fuelGauge.ReportLevel()}");
                Console.WriteLine($"Fuel level: {_fuelGauge.ReportLevel()}, please refill!");
                success = false;
            }

            return success;
        }


    }
}
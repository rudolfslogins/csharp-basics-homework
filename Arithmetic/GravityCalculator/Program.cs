using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = GetFinalPosition(gravity, fallingTime, initialVelocity, initialPosition);
            //double finalPosition = 0.5 * ((gravity * fallingTime)* (gravity * fallingTime))
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
        static double GetFinalPosition (double a, double t, double v, double x)
        {
            return (0.5 * (a * (t * t))) + (v * t) + x;
        }
    }
}

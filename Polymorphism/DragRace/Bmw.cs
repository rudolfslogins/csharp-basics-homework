using System;
namespace DragRace
{
    public class Bmw : ICar
    {
        private int currentSpeed = 0;

        public string Name()
        {
            return "BMW";
        }

        public void SpeedUp()
        {
            currentSpeed += 12;
        }

        public void SlowDown()
        {
            currentSpeed -= 12;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
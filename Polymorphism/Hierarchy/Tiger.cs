using System;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        public Tiger(string livingRegion, string name, string type, double weight) : base(livingRegion, name, type,
            weight)
        { }

        public override void makeSound()
        {
            Console.WriteLine(">Tiger makes sound now");
        }

        public override bool eat(Food feedFood)
        {
            if (feedFood is Meat)
            {
                FoodEaten = feedFood.Quantity;
                return true;
            }
            else
            {
                Console.WriteLine($">{AnimalType} are not eating that type of food!");
                return false;
            }
        }
    }
}
using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string livingRegion, string name, string type, double weight) : base(livingRegion, name, type,
            weight)
        { }

        public override void makeSound()
        {
            Console.WriteLine(">Zebra makes sound now");
        }
        public override bool eat(Food feedFood)
        {
            if (feedFood is Vegetable)
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
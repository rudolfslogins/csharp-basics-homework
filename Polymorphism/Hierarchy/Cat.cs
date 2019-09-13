using System;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private string _breed;

        public Cat(string breed, string livingRegion, string name, string type, double weight) : base(livingRegion, name, type, weight)
        {
            _breed = breed;
        }

        public override void makeSound()
        {
            Console.WriteLine(">Cat meows now (kinda makes sound)");
        }

        public override bool eat(Food feedFood)
        {
            FoodEaten = feedFood.Quantity;
            return true;
        }
        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {_breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
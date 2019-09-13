namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion;

        protected Mammal(string livingRegion, string name, string type, double weight) : base(name, type, weight)
        {
            LivingRegion = livingRegion;
        }
        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
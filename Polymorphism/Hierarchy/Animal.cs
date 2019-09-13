namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; }
        public string AnimalType { get; }
        public double AnimalWeight { get; }
        public int FoodEaten { get; set; }

        protected Animal(string name, string type, double weight)
        {
            AnimalName = name;
            AnimalType = type;
            AnimalWeight = weight;
        }

        public abstract void makeSound();

        public abstract bool eat(Food input);

    }
}
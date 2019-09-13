using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Console.WriteLine("---===ANIMAL FEEDER===---\n");
            do
            {
                Console.WriteLine(">Please enter Animal info in format: AnimalType AnimalName AnimalWeight AnimalLivingRegion CatBreed (Only if its cat)");
                var input1 = Console.ReadLine();
                string[] input1Arr = input1.Split(' ');
                if (input1Arr[0] == "Mouse" || input1Arr[0] == "mouse")
                {
                    animals.Add(new Mouse(input1Arr[3],input1Arr[1], input1Arr[0],Convert.ToDouble(input1Arr[2])));
                }
                else if (input1Arr[0] == "Zebra" || input1Arr[0] == "zebra")
                {
                    animals.Add(new Zebra(input1Arr[3], input1Arr[1], input1Arr[0], Convert.ToDouble(input1Arr[2])));
                }
                else if (input1Arr[0] == "Tiger" || input1Arr[0] == "tiger")
                {
                    animals.Add(new Tiger(input1Arr[3], input1Arr[1], input1Arr[0], Convert.ToDouble(input1Arr[2])));
                }
                else if (input1Arr[0] == "Cat" || input1Arr[0] == "cat")
                {
                    animals.Add(new Cat(input1Arr[4],input1Arr[3], input1Arr[1], input1Arr[0], Convert.ToDouble(input1Arr[2])));
                }
                else if (input1Arr[0] == "End" || input1Arr[0] == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(">Input was not correct!");
                    break;
                }
                animals[animals.Count - 1].makeSound();

                Console.WriteLine(">Please enter Food info in format: FoodType Quantity");
                var input2 = Console.ReadLine();
                string[] input2Arr = input2.Split(' ');
                if (input2Arr[0] == "Vegetable" || input2Arr[0] == "vegetable")
                {
                    if (animals[animals.Count - 1].eat(new Vegetable(Convert.ToInt16(input2Arr[1]))))
                    {
                        Console.WriteLine(">" + animals[animals.Count - 1]);
                    }
                }
                else if (input2Arr[0] == "Meat" || input2Arr[0] == "meat")
                {
                    if (animals[animals.Count - 1].eat(new Meat(Convert.ToInt16(input2Arr[1]))))
                    {
                        Console.WriteLine(">" + animals[animals.Count - 1]);
                    }
                }
                else
                {
                    Console.WriteLine(">Input was not correct!");
                    break;
                }
            } while (true);
            Console.WriteLine(">"+string.Join(", ", animals));
            Console.ReadKey();

        }
    }
}

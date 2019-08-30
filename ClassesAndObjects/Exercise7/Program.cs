using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male");
            Dog rocky = new Dog("Rocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female");

            max.SetParents("Lady", "Rocky");
            coco.SetParents("Molly", "Buster");
            rocky.SetParents("Molly", "Sam");
            buster.SetParents("Lady", "Sparky");

            Console.WriteLine(coco.GetFathersName());
            Console.WriteLine(sparky.GetFathersName());
            Console.WriteLine(coco.HasSameMotherAs(rocky));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand1 = new Random();
            Console.WriteLine("Please enter desired sum below:");
            int desiredSum = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Clear();
            Console.WriteLine($"Desired sum: { desiredSum }");
            do
            {
                var diceOne = rand1.Next(1, 7);
                var diceTwo = rand1.Next(1, 7);
                Console.WriteLine($"{diceOne} and {diceTwo} = {diceOne + diceTwo}");
                sum = diceOne + diceTwo;
            } while (desiredSum != sum);
            Console.ReadKey();
        }

    }
}

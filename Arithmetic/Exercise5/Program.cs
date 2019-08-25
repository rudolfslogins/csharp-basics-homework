using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            Console.WriteLine($"I'm thinking of a number between 1-100.  Try to guess it.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > randomNumber)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of { randomNumber }!");
                Console.ReadKey();
            } else if (userInput < randomNumber)
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of { randomNumber }!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"You guessed it!  What are the odds?!?");
                Console.ReadKey();
            }
        }
    }
}
